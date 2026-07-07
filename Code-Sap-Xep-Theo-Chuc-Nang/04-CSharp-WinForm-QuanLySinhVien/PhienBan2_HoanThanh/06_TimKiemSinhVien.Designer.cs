namespace ahihi1
{
    partial class ftimkiem
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
            this.labeltimkiemsinhvien = new System.Windows.Forms.Label();
            this.groupBoxketquatimkiem = new System.Windows.Forms.GroupBox();
            this.dataGridViewketquatimkiem = new System.Windows.Forms.DataGridView();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.labeltkmasv = new System.Windows.Forms.Label();
            this.cmdtimkiem = new System.Windows.Forms.Button();
            this.cmdtatca = new System.Windows.Forms.Button();
            this.groupBoxketquatimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewketquatimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltimkiemsinhvien
            // 
            this.labeltimkiemsinhvien.AutoSize = true;
            this.labeltimkiemsinhvien.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimkiemsinhvien.ForeColor = System.Drawing.Color.Blue;
            this.labeltimkiemsinhvien.Location = new System.Drawing.Point(253, -4);
            this.labeltimkiemsinhvien.Name = "labeltimkiemsinhvien";
            this.labeltimkiemsinhvien.Size = new System.Drawing.Size(330, 47);
            this.labeltimkiemsinhvien.TabIndex = 0;
            this.labeltimkiemsinhvien.Text = "Tìm kiếm sinh viên";
            // 
            // groupBoxketquatimkiem
            // 
            this.groupBoxketquatimkiem.Controls.Add(this.dataGridViewketquatimkiem);
            this.groupBoxketquatimkiem.Location = new System.Drawing.Point(16, 80);
            this.groupBoxketquatimkiem.Name = "groupBoxketquatimkiem";
            this.groupBoxketquatimkiem.Size = new System.Drawing.Size(854, 287);
            this.groupBoxketquatimkiem.TabIndex = 1;
            this.groupBoxketquatimkiem.TabStop = false;
            this.groupBoxketquatimkiem.Text = "Kết quả tìm kiếm";
            // 
            // dataGridViewketquatimkiem
            // 
            this.dataGridViewketquatimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewketquatimkiem.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewketquatimkiem.Name = "dataGridViewketquatimkiem";
            this.dataGridViewketquatimkiem.Size = new System.Drawing.Size(841, 261);
            this.dataGridViewketquatimkiem.TabIndex = 0;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(223, 51);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(424, 20);
            this.txtmasv.TabIndex = 3;
            this.txtmasv.TextChanged += new System.EventHandler(this.txtmasv_TextChanged);
            // 
            // labeltkmasv
            // 
            this.labeltkmasv.AutoSize = true;
            this.labeltkmasv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltkmasv.Location = new System.Drawing.Point(155, 54);
            this.labeltkmasv.Name = "labeltkmasv";
            this.labeltkmasv.Size = new System.Drawing.Size(39, 13);
            this.labeltkmasv.TabIndex = 2;
            this.labeltkmasv.Text = "Mã SV";
            // 
            // cmdtimkiem
            // 
            this.cmdtimkiem.Location = new System.Drawing.Point(694, 42);
            this.cmdtimkiem.Name = "cmdtimkiem";
            this.cmdtimkiem.Size = new System.Drawing.Size(89, 37);
            this.cmdtimkiem.TabIndex = 5;
            this.cmdtimkiem.Text = "Tìm kiếm";
            this.cmdtimkiem.UseVisualStyleBackColor = true;
            this.cmdtimkiem.Click += new System.EventHandler(this.cmdtimkiem_Click);
            // 
            // cmdtatca
            // 
            this.cmdtatca.Location = new System.Drawing.Point(24, 49);
            this.cmdtatca.Name = "cmdtatca";
            this.cmdtatca.Size = new System.Drawing.Size(98, 23);
            this.cmdtatca.TabIndex = 6;
            this.cmdtatca.Text = "Hiển thị tất cả";
            this.cmdtatca.UseVisualStyleBackColor = true;
            this.cmdtatca.Click += new System.EventHandler(this.cmdtatca_Click);
            // 
            // ftimkiem
            // 
            this.AcceptButton = this.cmdtimkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 372);
            this.Controls.Add(this.cmdtatca);
            this.Controls.Add(this.cmdtimkiem);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.labeltkmasv);
            this.Controls.Add(this.groupBoxketquatimkiem);
            this.Controls.Add(this.labeltimkiemsinhvien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ftimkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.ftimkiem_Load);
            this.groupBoxketquatimkiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewketquatimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltimkiemsinhvien;
        private System.Windows.Forms.GroupBox groupBoxketquatimkiem;
        private System.Windows.Forms.DataGridView dataGridViewketquatimkiem;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label labeltkmasv;
        private System.Windows.Forms.Button cmdtimkiem;
        private System.Windows.Forms.Button cmdtatca;
    }
}