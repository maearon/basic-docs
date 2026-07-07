namespace WindowsFormsApplication7
{
    partial class timkiem
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
            this.cmdtimkiem = new System.Windows.Forms.Button();
            this.groupBoxketquatimkiem = new System.Windows.Forms.GroupBox();
            this.dataGridViewketquatimkiem = new System.Windows.Forms.DataGridView();
            this.labeltimkiemsinhvien = new System.Windows.Forms.Label();
            this.cmdtatca = new System.Windows.Forms.Button();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.labeltkmasv = new System.Windows.Forms.Label();
            this.groupBoxketquatimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewketquatimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdtimkiem
            // 
            this.cmdtimkiem.Location = new System.Drawing.Point(526, 50);
            this.cmdtimkiem.Name = "cmdtimkiem";
            this.cmdtimkiem.Size = new System.Drawing.Size(69, 22);
            this.cmdtimkiem.TabIndex = 11;
            this.cmdtimkiem.Text = "Tìm kiếm";
            this.cmdtimkiem.UseVisualStyleBackColor = true;
            this.cmdtimkiem.Click += new System.EventHandler(this.cmdtimkiem_Click);
            // 
            // groupBoxketquatimkiem
            // 
            this.groupBoxketquatimkiem.Controls.Add(this.dataGridViewketquatimkiem);
            this.groupBoxketquatimkiem.Location = new System.Drawing.Point(30, 120);
            this.groupBoxketquatimkiem.Name = "groupBoxketquatimkiem";
            this.groupBoxketquatimkiem.Size = new System.Drawing.Size(849, 287);
            this.groupBoxketquatimkiem.TabIndex = 8;
            this.groupBoxketquatimkiem.TabStop = false;
            this.groupBoxketquatimkiem.Text = "Kết quả tìm kiếm";
            // 
            // dataGridViewketquatimkiem
            // 
            this.dataGridViewketquatimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewketquatimkiem.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewketquatimkiem.Name = "dataGridViewketquatimkiem";
            this.dataGridViewketquatimkiem.Size = new System.Drawing.Size(836, 254);
            this.dataGridViewketquatimkiem.TabIndex = 0;
            this.dataGridViewketquatimkiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewketquatimkiem_CellContentClick);
            // 
            // labeltimkiemsinhvien
            // 
            this.labeltimkiemsinhvien.AutoSize = true;
            this.labeltimkiemsinhvien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimkiemsinhvien.ForeColor = System.Drawing.Color.Blue;
            this.labeltimkiemsinhvien.Location = new System.Drawing.Point(217, 6);
            this.labeltimkiemsinhvien.Name = "labeltimkiemsinhvien";
            this.labeltimkiemsinhvien.Size = new System.Drawing.Size(198, 30);
            this.labeltimkiemsinhvien.TabIndex = 7;
            this.labeltimkiemsinhvien.Text = "Tìm kiếm sinh viên";
            // 
            // cmdtatca
            // 
            this.cmdtatca.Location = new System.Drawing.Point(36, 91);
            this.cmdtatca.Name = "cmdtatca";
            this.cmdtatca.Size = new System.Drawing.Size(98, 23);
            this.cmdtatca.TabIndex = 12;
            this.cmdtatca.Text = "Hiển thị tất cả";
            this.cmdtatca.UseVisualStyleBackColor = true;
            this.cmdtatca.Click += new System.EventHandler(this.cmdtatca_Click);
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(96, 52);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(424, 20);
            this.txtmasv.TabIndex = 10;
            this.txtmasv.TextChanged += new System.EventHandler(this.txtmasv_TextChanged);
            // 
            // labeltkmasv
            // 
            this.labeltkmasv.AutoSize = true;
            this.labeltkmasv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltkmasv.Location = new System.Drawing.Point(27, 55);
            this.labeltkmasv.Name = "labeltkmasv";
            this.labeltkmasv.Size = new System.Drawing.Size(39, 13);
            this.labeltkmasv.TabIndex = 9;
            this.labeltkmasv.Text = "Mã SV";
            // 
            // timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 432);
            this.Controls.Add(this.cmdtimkiem);
            this.Controls.Add(this.groupBoxketquatimkiem);
            this.Controls.Add(this.labeltimkiemsinhvien);
            this.Controls.Add(this.cmdtatca);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.labeltkmasv);
            this.Name = "timkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sinh viên";
            this.Load += new System.EventHandler(this.SuaND_Load);
            this.groupBoxketquatimkiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewketquatimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdtimkiem;
        private System.Windows.Forms.GroupBox groupBoxketquatimkiem;
        private System.Windows.Forms.DataGridView dataGridViewketquatimkiem;
        private System.Windows.Forms.Label labeltimkiemsinhvien;
        private System.Windows.Forms.Button cmdtatca;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label labeltkmasv;
    }
}