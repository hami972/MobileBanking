namespace Mobile_Banking.views
{
    partial class QRCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbTaiKhoanNguon = new System.Windows.Forms.ComboBox();
            this.tbNoiDungGiaoDich = new System.Windows.Forms.TextBox();
            this.tbSoTienGiaoDich = new System.Windows.Forms.TextBox();
            this.tbSTKHuongThu = new System.Windows.Forms.TextBox();
            this.btHoanTatGiaoDich = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbTaiKhoanNguon
            // 
            this.cbbTaiKhoanNguon.FormattingEnabled = true;
            this.cbbTaiKhoanNguon.Location = new System.Drawing.Point(220, 90);
            this.cbbTaiKhoanNguon.Name = "cbbTaiKhoanNguon";
            this.cbbTaiKhoanNguon.Size = new System.Drawing.Size(188, 24);
            this.cbbTaiKhoanNguon.TabIndex = 24;
            // 
            // tbNoiDungGiaoDich
            // 
            this.tbNoiDungGiaoDich.Location = new System.Drawing.Point(220, 333);
            this.tbNoiDungGiaoDich.Name = "tbNoiDungGiaoDich";
            this.tbNoiDungGiaoDich.Size = new System.Drawing.Size(188, 22);
            this.tbNoiDungGiaoDich.TabIndex = 23;
            this.tbNoiDungGiaoDich.TextChanged += new System.EventHandler(this.tbNoiDungGiaoDich_TextChanged);
            // 
            // tbSoTienGiaoDich
            // 
            this.tbSoTienGiaoDich.Location = new System.Drawing.Point(220, 294);
            this.tbSoTienGiaoDich.Name = "tbSoTienGiaoDich";
            this.tbSoTienGiaoDich.Size = new System.Drawing.Size(188, 22);
            this.tbSoTienGiaoDich.TabIndex = 22;
            this.tbSoTienGiaoDich.TextChanged += new System.EventHandler(this.tbSoTienGiaoDich_TextChanged);
            // 
            // tbSTKHuongThu
            // 
            this.tbSTKHuongThu.Location = new System.Drawing.Point(220, 249);
            this.tbSTKHuongThu.Name = "tbSTKHuongThu";
            this.tbSTKHuongThu.Size = new System.Drawing.Size(188, 22);
            this.tbSTKHuongThu.TabIndex = 21;
            this.tbSTKHuongThu.TextChanged += new System.EventHandler(this.tbSTKHuongThu_TextChanged);
            // 
            // btHoanTatGiaoDich
            // 
            this.btHoanTatGiaoDich.BackColor = System.Drawing.Color.CadetBlue;
            this.btHoanTatGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoanTatGiaoDich.ForeColor = System.Drawing.Color.Transparent;
            this.btHoanTatGiaoDich.Location = new System.Drawing.Point(155, 386);
            this.btHoanTatGiaoDich.Name = "btHoanTatGiaoDich";
            this.btHoanTatGiaoDich.Size = new System.Drawing.Size(130, 51);
            this.btHoanTatGiaoDich.TabIndex = 20;
            this.btHoanTatGiaoDich.Text = "Hoàn tất";
            this.btHoanTatGiaoDich.UseVisualStyleBackColor = false;
            this.btHoanTatGiaoDich.Click += new System.EventHandler(this.btHoanTatGiaoDich_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(31, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nội dung giao dịch";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(42, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số tiền giao dịch:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(53, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "STK thụ hưởng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(39, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tài khoản nguồn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(4, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ngân hàng thụ hưởng";
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbTaiKhoanNguon);
            this.Controls.Add(this.tbNoiDungGiaoDich);
            this.Controls.Add(this.tbSoTienGiaoDich);
            this.Controls.Add(this.tbSTKHuongThu);
            this.Controls.Add(this.btHoanTatGiaoDich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QRCode";
            this.Size = new System.Drawing.Size(438, 506);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTaiKhoanNguon;
        private System.Windows.Forms.TextBox tbNoiDungGiaoDich;
        private System.Windows.Forms.TextBox tbSoTienGiaoDich;
        private System.Windows.Forms.TextBox tbSTKHuongThu;
        private System.Windows.Forms.Button btHoanTatGiaoDich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}
