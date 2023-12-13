namespace Mobile_Banking.views
{
    partial class LichSuGiaoDich
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
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.White;
            this.lbNgay.Location = new System.Drawing.Point(26, 3);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(73, 25);
            this.lbNgay.TabIndex = 0;
            this.lbNgay.Text = "lbNgay";
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.ForeColor = System.Drawing.Color.White;
            this.lbNoiDung.Location = new System.Drawing.Point(26, 37);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(103, 25);
            this.lbNoiDung.TabIndex = 1;
            this.lbNoiDung.Text = "lbNoiDung";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.ForeColor = System.Drawing.Color.Transparent;
            this.lbTien.Location = new System.Drawing.Point(257, 37);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(66, 25);
            this.lbTien.TabIndex = 2;
            this.lbTien.Text = "lbTien";
            // 
            // LichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.lbNoiDung);
            this.Controls.Add(this.lbNgay);
            this.Name = "LichSuGiaoDich";
            this.Size = new System.Drawing.Size(376, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.Label lbTien;
    }
}
