namespace Storeproject
{
    partial class FrmProductCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.rdoProStatusOf = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btProImage = new System.Windows.Forms.Panel();
            this.pcbProImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).BeginInit();
            this.btProImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("AngsanaUPC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(98, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(961, 129);
            this.label2.TabIndex = 2;
            this.label2.Text = "เพิ่มสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(394, 1119);
            this.nudProQuan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProQuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProQuan.Name = "nudProQuan";
            this.nudProQuan.Size = new System.Drawing.Size(510, 38);
            this.nudProQuan.TabIndex = 32;
            this.nudProQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdoProStatusOf
            // 
            this.rdoProStatusOf.AutoSize = true;
            this.rdoProStatusOf.Checked = true;
            this.rdoProStatusOf.Location = new System.Drawing.Point(718, 1296);
            this.rdoProStatusOf.Name = "rdoProStatusOf";
            this.rdoProStatusOf.Size = new System.Drawing.Size(186, 36);
            this.rdoProStatusOf.TabIndex = 31;
            this.rdoProStatusOf.TabStop = true;
            this.rdoProStatusOf.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOf.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(381, 1291);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(156, 36);
            this.rdoProStatusOn.TabIndex = 30;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // tbProUnit
            // 
            this.tbProUnit.Location = new System.Drawing.Point(394, 1212);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(510, 38);
            this.tbProUnit.TabIndex = 29;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(394, 1026);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(510, 38);
            this.tbProPrice.TabIndex = 28;
            this.tbProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProPrice_KeyPress);
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(394, 935);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(510, 38);
            this.tbProName.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 1296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "สถานะสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 1212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "หน่วยสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 1119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 1026);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "ราคาสินค้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 935);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // btSave
            // 
            this.btSave.Image = global::Storeproject.Properties.Resources.save;
            this.btSave.Location = new System.Drawing.Point(647, 1380);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(242, 65);
            this.btSave.TabIndex = 34;
            this.btSave.Text = "บันทึกเพิ่มสินค้า";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = global::Storeproject.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(367, 1380);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(242, 65);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btProImage
            // 
            this.btProImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btProImage.Controls.Add(this.pcbProImage);
            this.btProImage.Location = new System.Drawing.Point(306, 309);
            this.btProImage.Name = "btProImage";
            this.btProImage.Size = new System.Drawing.Size(612, 506);
            this.btProImage.TabIndex = 35;
            // 
            // pcbProImage
            // 
            this.pcbProImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbProImage.Location = new System.Drawing.Point(34, 33);
            this.pcbProImage.Name = "pcbProImage";
            this.pcbProImage.Size = new System.Drawing.Size(546, 443);
            this.pcbProImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProImage.TabIndex = 0;
            this.pcbProImage.TabStop = false;
            this.pcbProImage.SizeModeChanged += new System.EventHandler(this.pcbProImage_SizeModeChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(972, 759);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 55);
            this.button1.TabIndex = 36;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btProImage);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.rdoProStatusOf);
            this.Controls.Add(this.rdoProStatusOn);
            this.Controls.Add(this.tbProUnit);
            this.Controls.Add(this.tbProPrice);
            this.Controls.Add(this.tbProName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มสินค้า - บริหารจัดการข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.FrmProductCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).EndInit();
            this.btProImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.NumericUpDown nudProQuan;
        private System.Windows.Forms.RadioButton rdoProStatusOf;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.TextBox tbProUnit;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.TextBox tbProName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btProImage;
        private System.Windows.Forms.PictureBox pcbProImage;
        private System.Windows.Forms.Button button1;
    }
}

