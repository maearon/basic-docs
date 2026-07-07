namespace ahihi1
{
    partial class fdangnhap
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
            this.buttondangnhap = new System.Windows.Forms.Button();
            this.labeltaikhoan = new System.Windows.Forms.Label();
            this.labelmatkhau = new System.Windows.Forms.Label();
            this.groupBoxthongtindangnhap = new System.Windows.Forms.GroupBox();
            this.textBoxmatkhau = new System.Windows.Forms.TextBox();
            this.textBoxtaikhoan = new System.Windows.Forms.TextBox();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.groupBoxthongtindangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttondangnhap
            // 
            this.buttondangnhap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondangnhap.Location = new System.Drawing.Point(107, 94);
            this.buttondangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.buttondangnhap.Name = "buttondangnhap";
            this.buttondangnhap.Size = new System.Drawing.Size(81, 25);
            this.buttondangnhap.TabIndex = 3;
            this.buttondangnhap.Text = "Đăng nhập";
            this.buttondangnhap.UseVisualStyleBackColor = true;
            this.buttondangnhap.Click += new System.EventHandler(this.buttondangnhap_Click);
            // 
            // labeltaikhoan
            // 
            this.labeltaikhoan.AutoSize = true;
            this.labeltaikhoan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltaikhoan.Location = new System.Drawing.Point(13, 34);
            this.labeltaikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltaikhoan.Name = "labeltaikhoan";
            this.labeltaikhoan.Size = new System.Drawing.Size(59, 13);
            this.labeltaikhoan.TabIndex = 1;
            this.labeltaikhoan.Text = "Tài khoản:";
            // 
            // labelmatkhau
            // 
            this.labelmatkhau.AutoSize = true;
            this.labelmatkhau.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatkhau.Location = new System.Drawing.Point(13, 62);
            this.labelmatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmatkhau.Name = "labelmatkhau";
            this.labelmatkhau.Size = new System.Drawing.Size(59, 13);
            this.labelmatkhau.TabIndex = 2;
            this.labelmatkhau.Text = "Mật khẩu:";
            // 
            // groupBoxthongtindangnhap
            // 
            this.groupBoxthongtindangnhap.Controls.Add(this.textBoxmatkhau);
            this.groupBoxthongtindangnhap.Controls.Add(this.textBoxtaikhoan);
            this.groupBoxthongtindangnhap.Controls.Add(this.labeltaikhoan);
            this.groupBoxthongtindangnhap.Controls.Add(this.labelmatkhau);
            this.groupBoxthongtindangnhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxthongtindangnhap.Location = new System.Drawing.Point(3, 3);
            this.groupBoxthongtindangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxthongtindangnhap.Name = "groupBoxthongtindangnhap";
            this.groupBoxthongtindangnhap.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxthongtindangnhap.Size = new System.Drawing.Size(267, 89);
            this.groupBoxthongtindangnhap.TabIndex = 3;
            this.groupBoxthongtindangnhap.TabStop = false;
            this.groupBoxthongtindangnhap.Text = "Thông tin đăng nhập";
            this.groupBoxthongtindangnhap.Enter += new System.EventHandler(this.groupBoxthongtindangnhap_Enter);
            // 
            // textBoxmatkhau
            // 
            this.textBoxmatkhau.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmatkhau.Location = new System.Drawing.Point(80, 59);
            this.textBoxmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxmatkhau.Name = "textBoxmatkhau";
            this.textBoxmatkhau.Size = new System.Drawing.Size(183, 22);
            this.textBoxmatkhau.TabIndex = 2;
            this.textBoxmatkhau.UseSystemPasswordChar = true;
            // 
            // textBoxtaikhoan
            // 
            this.textBoxtaikhoan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtaikhoan.Location = new System.Drawing.Point(80, 29);
            this.textBoxtaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxtaikhoan.Name = "textBoxtaikhoan";
            this.textBoxtaikhoan.Size = new System.Drawing.Size(183, 22);
            this.textBoxtaikhoan.TabIndex = 1;
            // 
            // buttonthoat
            // 
            this.buttonthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonthoat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthoat.Location = new System.Drawing.Point(196, 93);
            this.buttonthoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(74, 26);
            this.buttonthoat.TabIndex = 4;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // fdangnhap
            // 
            this.AcceptButton = this.buttondangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonthoat;
            this.ClientSize = new System.Drawing.Size(280, 128);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.groupBoxthongtindangnhap);
            this.Controls.Add(this.buttondangnhap);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fdangnhap_FormClosing);
            this.Load += new System.EventHandler(this.fdangnhap_Load);
            this.groupBoxthongtindangnhap.ResumeLayout(false);
            this.groupBoxthongtindangnhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttondangnhap;
        private System.Windows.Forms.Label labeltaikhoan;
        private System.Windows.Forms.Label labelmatkhau;
        private System.Windows.Forms.GroupBox groupBoxthongtindangnhap;
        private System.Windows.Forms.TextBox textBoxmatkhau;
        private System.Windows.Forms.TextBox textBoxtaikhoan;
        private System.Windows.Forms.Button buttonthoat;
    }
}

