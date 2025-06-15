namespace Storeproject
{
    partial class FrmProductShowAll
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
            this.lvAllProduct = new System.Windows.Forms.ListView();
            this.btnFrmProductCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvAllProduct
            // 
            this.lvAllProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAllProduct.HideSelection = false;
            this.lvAllProduct.Location = new System.Drawing.Point(102, 240);
            this.lvAllProduct.Name = "lvAllProduct";
            this.lvAllProduct.Size = new System.Drawing.Size(1993, 797);
            this.lvAllProduct.TabIndex = 7;
            this.lvAllProduct.UseCompatibleStateImageBehavior = false;
            // 
            // btnFrmProductCreate
            // 
            this.btnFrmProductCreate.Image = global::Storeproject.Properties.Resources.basket;
            this.btnFrmProductCreate.Location = new System.Drawing.Point(1443, 1125);
            this.btnFrmProductCreate.Name = "btnFrmProductCreate";
            this.btnFrmProductCreate.Size = new System.Drawing.Size(283, 70);
            this.btnFrmProductCreate.TabIndex = 6;
            this.btnFrmProductCreate.Text = "เพิ่มข้อมูลสินค้า";
            this.btnFrmProductCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFrmProductCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFrmProductCreate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("AngsanaUPC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(102, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1993, 129);
            this.label2.TabIndex = 5;
            this.label2.Text = "บริหารจัดการข้อมูลสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(906, 1242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(820, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "*เมื่อต้องการแก้ไขหรือลบข้อมูลสินค้า ให้Double Click ที่รายการสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FrmProductShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2214, 1327);
            this.Controls.Add(this.lvAllProduct);
            this.Controls.Add(this.btnFrmProductCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProductShowAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductShowAll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductShowAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAllProduct;
        private System.Windows.Forms.Button btnFrmProductCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}