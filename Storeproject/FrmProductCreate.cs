using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Storeproject
{
    public partial class FrmProductCreate : Form
    {
        //สร้างตัวแปรเก็บรูปที่เปลงเป็น Binary/Byte Array เอาไว้บันทึกลง DB
        byte[] proImage;


        public FrmProductCreate()
        {
            InitializeComponent();
        }

        //สร้าง เมธอดแปลงรูปเป็น Binary/Byte Array
        private byte[] convertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //เปิดไฟล์Dialog ให้เลือกรูป โดยเราจะ ฟิลเตอร์ เฉพาะไฟล์ jpg/png
            //แล้วนำรูปที่เลือกไปแสดงที่ pcbProImage
            //แล้วก็แปลงเป็น Binary/Byte เก็บในตัวแปรเพื่อเอาไว้บันทึกลง DB
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // เอารูปที่เลือกไปแสดงที่ picture box   pcbProImage
                pcbProImage.Image = Image.FromFile(openFileDialog.FileName);
                //ตรวจสอบ Format ของรูป แล้วส่งไปแปลงเป็น Binary/Byte เก็บในตัวแปร
                if (pcbProImage.Image.RawFormat == ImageFormat.Jpeg)
                {
                    proImage = convertImageToByteArray(pcbProImage.Image, ImageFormat.Jpeg);
                }
                else
                {
                    proImage = convertImageToByteArray(pcbProImage.Image, ImageFormat.Png);
                }
            }

        }

        private void pcbProImage_SizeModeChanged(object sender, EventArgs e)
        {

        }

        private void tbProPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // อนุญาตให้ป้อนเฉพาะตัวเลข, จุดทศนิยม, และ backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // ถ้ากดจุดทศนิยม
            if (e.KeyChar == '.')
            {
                // ถ้ามีจุดทศนิยมอยู่แล้ว ไม่ให้พิมพ์อีก
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }
            }

            // ตรวจสอบว่ามีจุดอยู่แล้ว และกำลังพิมพ์ต่อท้าย
            if (textBox.Text.Contains(".") && !char.IsControl(e.KeyChar))
            {
                int indexOfDot = textBox.Text.IndexOf('.');
                int digitsAfterDot = textBox.SelectionStart - indexOfDot;

                // ถ้ากำลังพิมพ์หลังจุด และเลย 1 ตำแหน่ง ให้ป้องกัน
                if (textBox.SelectionStart > indexOfDot && digitsAfterDot >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
        //สร้างเมธอด แสดงข้อความเตือน
        private void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            //Validate UI แล้วก็เอาข้อมูลไปบันทึกลง DB
            //พอบันทึกเสร็จแสดงข้อความบอกผู้ใช้ และ ปิดหน้าจอ FrmProductCreate แบบกลับไปยังหน้าจอ FrmProductShow
            if (proImage == null)
            {
                showWarningMSG("เลือกรูปด้วย");
            }
            else if (tbProName.Text.Length == 0)
            {
                showWarningMSG("ป้อนชื่อสินค้าด้วย");
            }
            else if (tbProPrice.Text.Length == 0)
            {
                showWarningMSG("ป้อนราคาสินค้าด้วย");
            }
            else if (int.Parse(nudProQuan.Value.ToString()) <= 0)
            {
                showWarningMSG("จำนวนสินค้าต้องมากกว่า 0");

            }
            else if (tbProUnit.Text.Length == 0)
            {
                showWarningMSG("ป้อนหน่วยสินค้าด้วย");
            }
            else
            {
                //บันทึกลง DB --> แสดง MSG --> ปิดหน้าจอ --> กลับไปยังหน้าจอหลัก FrmProductShow


                //กำหนด Connect String เพื่อติดต่อไปยัง ฐานข้อมูล
                string connectionString = @"Server=Jam;Database=store_db;Trusted_Connection=True";

                //สร้าง Connection ไปยังฐานข้อมูล
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlConnection.Open();

                        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction(); //ใช้กับ Insert / Update / Delete

                        //คำสั่ง SQL
                        string strSQL = "INSERT INTO product_tb (proName,proPrice,proQuan,proUnit,proStatus,proImage,createAt,updateAt) " +
                                        "VALUES (@proName,@proPrice,@proQuan,@proUnit,@proStatus,@proImage,@createAt,@updateAt)";
                        //กำหนดค่าให้กับ SQL Parameter และ สั่งให้คำสั่งSQL ทำงาน
                        using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                        {
                            sqlCommand.Parameters.Add("@proName", SqlDbType.NVarChar, 300).Value = tbProName.Text;
                            sqlCommand.Parameters.Add("@proPrice", SqlDbType.Float).Value =float.Parse(tbProPrice.Text);
                            sqlCommand.Parameters.Add("@proQuan", SqlDbType.Int).Value = int.Parse(nudProQuan.Value.ToString());
                            sqlCommand.Parameters.Add("@proUnit", SqlDbType.NVarChar, 50).Value = tbProUnit.Text;
                            if (rdoProStatusOn.Checked == true)
                            {
                                sqlCommand.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = "พร้อมขาย";
                            }
                            else
                            {
                                sqlCommand.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = "ไม่พร้อมขาย";
                            }
                            sqlCommand.Parameters.Add("@proImage", SqlDbType.Image).Value = proImage;
                            sqlCommand.Parameters.Add("@createAt", SqlDbType.Date).Value = DateTime.Now.Date;
                            sqlCommand.Parameters.Add("@updateAt", SqlDbType.Date).Value = DateTime.Now.Date;

                            //สั่งให้ คำสั่ง SQL ทำงาน
                            sqlCommand.ExecuteNonQuery();
                            sqlTransaction.Commit();

                            //ข้อความแจ้งเมื่อทำเสร็จ
                            MessageBox.Show("บันทึกเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //ปิดหน้าจอฟอร์มนี้ไป
                            this.Close();
                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                    }
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //Clear หน้าจอ
            proImage = null;
            tbProName.Clear();
            tbProPrice.Clear();
            nudProQuan.Value = 0;
            tbProUnit.Clear();
            pcbProImage.Image = null;
        }

        private void FrmProductCreate_Load(object sender, EventArgs e)
        {

        }
    }

}
