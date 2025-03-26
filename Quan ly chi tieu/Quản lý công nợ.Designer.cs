namespace Quan_ly_chi_tieu
{
    partial class Quản_lý_công_nợ
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttiemkiem = new System.Windows.Forms.TextBox();
            this.txtmacongno = new System.Windows.Forms.TextBox();
            this.txtnhacungcap = new System.Windows.Forms.TextBox();
            this.txtsotienno = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtongaydenhanthanhtoan = new System.Windows.Forms.DateTimePicker();
            this.rdbchuathanhtoan = new System.Windows.Forms.RadioButton();
            this.rdbdathanhtoan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(132, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý công nợ nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(238, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã công nợ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(299, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà cung cấp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(46, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền nợ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(299, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày đến hạn thanh toán";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(50, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trạng thái";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txttiemkiem
            // 
            this.txttiemkiem.Location = new System.Drawing.Point(183, 107);
            this.txttiemkiem.Name = "txttiemkiem";
            this.txttiemkiem.Size = new System.Drawing.Size(188, 22);
            this.txttiemkiem.TabIndex = 7;
            // 
            // txtmacongno
            // 
            this.txtmacongno.Location = new System.Drawing.Point(49, 210);
            this.txtmacongno.Name = "txtmacongno";
            this.txtmacongno.Size = new System.Drawing.Size(166, 22);
            this.txtmacongno.TabIndex = 8;
            this.txtmacongno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtnhacungcap
            // 
            this.txtnhacungcap.Location = new System.Drawing.Point(302, 210);
            this.txtnhacungcap.Name = "txtnhacungcap";
            this.txtnhacungcap.Size = new System.Drawing.Size(242, 22);
            this.txtnhacungcap.TabIndex = 9;
            this.txtnhacungcap.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtsotienno
            // 
            this.txtsotienno.Location = new System.Drawing.Point(49, 287);
            this.txtsotienno.Name = "txtsotienno";
            this.txtsotienno.Size = new System.Drawing.Size(166, 22);
            this.txtsotienno.TabIndex = 10;
            this.txtsotienno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthem.Location = new System.Drawing.Point(68, 402);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(86, 30);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsua.Location = new System.Drawing.Point(183, 402);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(86, 30);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sửa ";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnxoa.Location = new System.Drawing.Point(313, 402);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 30);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntimkiem.Location = new System.Drawing.Point(437, 402);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(86, 30);
            this.btntimkiem.TabIndex = 16;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(-11, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã công nợ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nhà cung cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số tiền nợ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày đến hạn thanh toán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // dtongaydenhanthanhtoan
            // 
            this.dtongaydenhanthanhtoan.Location = new System.Drawing.Point(302, 286);
            this.dtongaydenhanthanhtoan.Name = "dtongaydenhanthanhtoan";
            this.dtongaydenhanthanhtoan.Size = new System.Drawing.Size(242, 22);
            this.dtongaydenhanthanhtoan.TabIndex = 18;
            // 
            // rdbchuathanhtoan
            // 
            this.rdbchuathanhtoan.AutoSize = true;
            this.rdbchuathanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.rdbchuathanhtoan.Location = new System.Drawing.Point(53, 363);
            this.rdbchuathanhtoan.Name = "rdbchuathanhtoan";
            this.rdbchuathanhtoan.Size = new System.Drawing.Size(123, 20);
            this.rdbchuathanhtoan.TabIndex = 19;
            this.rdbchuathanhtoan.TabStop = true;
            this.rdbchuathanhtoan.Text = "Chưa thanh toán";
            this.rdbchuathanhtoan.UseVisualStyleBackColor = false;
            // 
            // rdbdathanhtoan
            // 
            this.rdbdathanhtoan.AutoSize = true;
            this.rdbdathanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.rdbdathanhtoan.Location = new System.Drawing.Point(194, 363);
            this.rdbdathanhtoan.Name = "rdbdathanhtoan";
            this.rdbdathanhtoan.Size = new System.Drawing.Size(109, 20);
            this.rdbdathanhtoan.TabIndex = 20;
            this.rdbdathanhtoan.TabStop = true;
            this.rdbdathanhtoan.Text = "Đã thanh toán";
            this.rdbdathanhtoan.UseVisualStyleBackColor = false;
            // 
            // Quản_lý_công_nợ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quan_ly_chi_tieu.Properties.Resources.Screenshot_2025_03_18_111055;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 584);
            this.Controls.Add(this.rdbdathanhtoan);
            this.Controls.Add(this.rdbchuathanhtoan);
            this.Controls.Add(this.dtongaydenhanthanhtoan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtsotienno);
            this.Controls.Add(this.txtnhacungcap);
            this.Controls.Add(this.txtmacongno);
            this.Controls.Add(this.txttiemkiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Quản_lý_công_nợ";
            this.Text = "Quản_lý_công_nợ";
            this.Load += new System.EventHandler(this.Quản_lý_công_nợ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttiemkiem;
        private System.Windows.Forms.TextBox txtmacongno;
        private System.Windows.Forms.TextBox txtnhacungcap;
        private System.Windows.Forms.TextBox txtsotienno;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dtongaydenhanthanhtoan;
        private System.Windows.Forms.RadioButton rdbchuathanhtoan;
        private System.Windows.Forms.RadioButton rdbdathanhtoan;
    }
}