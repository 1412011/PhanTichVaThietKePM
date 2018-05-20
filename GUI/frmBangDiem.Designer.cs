namespace GUI
{
    partial class frmBangDiem
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
            this.grvDanhSach = new System.Windows.Forms.DataGridView();
            this.bd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDanhSach
            // 
            this.grvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bd1,
            this.bd2,
            this.bd3,
            this.bd4,
            this.bd5,
            this.bd6,
            this.bd7});
            this.grvDanhSach.Location = new System.Drawing.Point(12, 90);
            this.grvDanhSach.Name = "grvDanhSach";
            this.grvDanhSach.Size = new System.Drawing.Size(705, 267);
            this.grvDanhSach.TabIndex = 0;
            // 
            // bd1
            // 
            this.bd1.HeaderText = "Mã môn học";
            this.bd1.Name = "bd1";
            // 
            // bd2
            // 
            this.bd2.HeaderText = "Tên môn học";
            this.bd2.Name = "bd2";
            // 
            // bd3
            // 
            this.bd3.HeaderText = "điểm 15ph";
            this.bd3.Name = "bd3";
            // 
            // bd4
            // 
            this.bd4.HeaderText = "điểm 1 tiết";
            this.bd4.Name = "bd4";
            // 
            // bd5
            // 
            this.bd5.HeaderText = "điểm giữa kỳ";
            this.bd5.Name = "bd5";
            // 
            // bd6
            // 
            this.bd6.HeaderText = "điểm cuối kỳ";
            this.bd6.Name = "bd6";
            // 
            // bd7
            // 
            this.bd7.HeaderText = "điểm tổng kết";
            this.bd7.Name = "bd7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm học";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học kỳ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Môn Lớp";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvDanhSach);
            this.Name = "frmBangDiem";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd6;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}