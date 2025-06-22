namespace Storeproject
{
    partial class FrmPruductUpDel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOf = new System.Windows.Forms.RadioButton();
            this.btProUpdate = new System.Windows.Forms.Button();
            this.btProDelete = new System.Windows.Forms.Button();
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.btProImage = new System.Windows.Forms.Panel();
            this.pcbProImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbProId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(99, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1016, 129);
            this.label2.TabIndex = 2;
            this.label2.Text = "แก้ไข/ลบสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 946);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 1037);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "ราคาสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 1130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 1223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "หน่วยสินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 1307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "สถานะสินค้า";
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(415, 946);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(510, 38);
            this.tbProName.TabIndex = 12;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(415, 1037);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(510, 38);
            this.tbProPrice.TabIndex = 13;
            // 
            // tbProUnit
            // 
            this.tbProUnit.Location = new System.Drawing.Point(415, 1223);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(510, 38);
            this.tbProUnit.TabIndex = 14;
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(402, 1302);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(156, 36);
            this.rdoProStatusOn.TabIndex = 15;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOf
            // 
            this.rdoProStatusOf.AutoSize = true;
            this.rdoProStatusOf.Checked = true;
            this.rdoProStatusOf.Location = new System.Drawing.Point(739, 1307);
            this.rdoProStatusOf.Name = "rdoProStatusOf";
            this.rdoProStatusOf.Size = new System.Drawing.Size(186, 36);
            this.rdoProStatusOf.TabIndex = 16;
            this.rdoProStatusOf.TabStop = true;
            this.rdoProStatusOf.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOf.UseVisualStyleBackColor = true;
            // 
            // btProUpdate
            // 
            this.btProUpdate.Image = global::Storeproject.Properties.Resources.update;
            this.btProUpdate.Location = new System.Drawing.Point(668, 1391);
            this.btProUpdate.Name = "btProUpdate";
            this.btProUpdate.Size = new System.Drawing.Size(242, 65);
            this.btProUpdate.TabIndex = 19;
            this.btProUpdate.Text = "บันทึกแก้ไขสินค้า";
            this.btProUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProUpdate.UseVisualStyleBackColor = true;
            this.btProUpdate.Click += new System.EventHandler(this.btProUpdate_Click);
            // 
            // btProDelete
            // 
            this.btProDelete.Image = global::Storeproject.Properties.Resources.delete;
            this.btProDelete.Location = new System.Drawing.Point(388, 1391);
            this.btProDelete.Name = "btProDelete";
            this.btProDelete.Size = new System.Drawing.Size(242, 65);
            this.btProDelete.TabIndex = 18;
            this.btProDelete.Text = "ลบสินค้า";
            this.btProDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProDelete.UseVisualStyleBackColor = true;
            this.btProDelete.Click += new System.EventHandler(this.btProDelete_Click);
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(415, 1130);
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
            this.nudProQuan.TabIndex = 33;
            this.nudProQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btProImage
            // 
            this.btProImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btProImage.Controls.Add(this.pcbProImage);
            this.btProImage.Location = new System.Drawing.Point(294, 260);
            this.btProImage.Name = "btProImage";
            this.btProImage.Size = new System.Drawing.Size(631, 509);
            this.btProImage.TabIndex = 34;
            // 
            // pcbProImage
            // 
            this.pcbProImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbProImage.Location = new System.Drawing.Point(29, 26);
            this.pcbProImage.Name = "pcbProImage";
            this.pcbProImage.Size = new System.Drawing.Size(572, 454);
            this.pcbProImage.TabIndex = 0;
            this.pcbProImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 715);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 53);
            this.button1.TabIndex = 35;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbProId
            // 
            this.tbProId.Location = new System.Drawing.Point(415, 850);
            this.tbProId.Name = "tbProId";
            this.tbProId.ReadOnly = true;
            this.tbProId.Size = new System.Drawing.Size(510, 38);
            this.tbProId.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 850);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 32);
            this.label7.TabIndex = 36;
            this.label7.Text = "รหัสสินค้า";
            // 
            // FrmPruductUpDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1516);
            this.Controls.Add(this.tbProId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btProImage);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.btProUpdate);
            this.Controls.Add(this.btProDelete);
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
            this.Name = "FrmPruductUpDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "แก้ไข/ลบสินค้า - บริหารจัดการข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.FrmPruductUpDel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).EndInit();
            this.btProImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProName;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.TextBox tbProUnit;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.RadioButton rdoProStatusOf;
        private System.Windows.Forms.Button btProDelete;
        private System.Windows.Forms.Button btProUpdate;
        private System.Windows.Forms.NumericUpDown nudProQuan;
        private System.Windows.Forms.Panel btProImage;
        private System.Windows.Forms.PictureBox pcbProImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbProId;
        private System.Windows.Forms.Label label7;
    }
}