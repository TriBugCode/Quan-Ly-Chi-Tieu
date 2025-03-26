namespace Quan_ly_chi_tieu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTTimkiem = new System.Windows.Forms.TextBox();
            this.TxtMathunhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bbtnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.DGVquanlythunhap = new System.Windows.Forms.DataGridView();
            this.Mathunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpngayghinhan = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVquanlythunhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(162, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thu nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(212, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXTTimkiem
            // 
            this.TXTTimkiem.Location = new System.Drawing.Point(131, 143);
            this.TXTTimkiem.Name = "TXTTimkiem";
            this.TXTTimkiem.Size = new System.Drawing.Size(241, 22);
            this.TXTTimkiem.TabIndex = 2;
            this.TXTTimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtMathunhap
            // 
            this.TxtMathunhap.Location = new System.Drawing.Point(28, 218);
            this.TxtMathunhap.Name = "TxtMathunhap";
            this.TxtMathunhap.Size = new System.Drawing.Size(180, 22);
            this.TxtMathunhap.TabIndex = 4;
            this.TxtMathunhap.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã thu nhập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(282, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày ghi nhận";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(28, 288);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(180, 22);
            this.txtsotien.TabIndex = 8;
            this.txtsotien.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(286, 288);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(227, 22);
            this.txtghichu.TabIndex = 10;
            this.txtghichu.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(293, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ghi chú";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bbtnthem
            // 
            this.bbtnthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bbtnthem.Location = new System.Drawing.Point(74, 351);
            this.bbtnthem.Name = "bbtnthem";
            this.bbtnthem.Size = new System.Drawing.Size(75, 23);
            this.bbtnthem.TabIndex = 11;
            this.bbtnthem.Text = "Thêm ";
            this.bbtnthem.UseVisualStyleBackColor = true;
            this.bbtnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsua
            // 
            this.btnsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsua.Location = new System.Drawing.Point(175, 351);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa ";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnxoa.Location = new System.Drawing.Point(278, 351);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntimkiem.Location = new System.Drawing.Point(379, 351);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 14;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.button4_Click);
            // 
            // DGVquanlythunhap
            // 
            this.DGVquanlythunhap.AllowUserToOrderColumns = true;
            this.DGVquanlythunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVquanlythunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathunhap,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGVquanlythunhap.Location = new System.Drawing.Point(0, 408);
            this.DGVquanlythunhap.Name = "DGVquanlythunhap";
            this.DGVquanlythunhap.RowHeadersWidth = 51;
            this.DGVquanlythunhap.RowTemplate.Height = 24;
            this.DGVquanlythunhap.Size = new System.Drawing.Size(552, 150);
            this.DGVquanlythunhap.TabIndex = 15;
            // 
            // Mathunhap
            // 
            this.Mathunhap.HeaderText = "Mã thu nhập";
            this.Mathunhap.MinimumWidth = 6;
            this.Mathunhap.Name = "Mathunhap";
            this.Mathunhap.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ngày ghi nhận";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "số tiền";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ghi chú";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // dtpngayghinhan
            // 
            this.dtpngayghinhan.Location = new System.Drawing.Point(286, 218);
            this.dtpngayghinhan.Name = "dtpngayghinhan";
            this.dtpngayghinhan.Size = new System.Drawing.Size(227, 22);
            this.dtpngayghinhan.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Quan_ly_chi_tieu.Properties.Resources.Screenshot_2025_03_18_111055;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 554);
            this.Controls.Add(this.dtpngayghinhan);
            this.Controls.Add(this.DGVquanlythunhap);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.bbtnthem);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMathunhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTTimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVquanlythunhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTTimkiem;
        private System.Windows.Forms.TextBox TxtMathunhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bbtnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView DGVquanlythunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DateTimePicker dtpngayghinhan;
    }
}