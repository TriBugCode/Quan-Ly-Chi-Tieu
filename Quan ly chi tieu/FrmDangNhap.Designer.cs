namespace Quan_ly_chi_tieu
{
    partial class FrmDangNhap
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
            this.cbghinhomatkhau = new System.Windows.Forms.CheckBox();
            this.txtquenmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.btnquenmatkkhau = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbghinhomatkhau
            // 
            this.cbghinhomatkhau.AutoSize = true;
            this.cbghinhomatkhau.BackColor = System.Drawing.Color.Transparent;
            this.cbghinhomatkhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbghinhomatkhau.Location = new System.Drawing.Point(13, 239);
            this.cbghinhomatkhau.Name = "cbghinhomatkhau";
            this.cbghinhomatkhau.Size = new System.Drawing.Size(131, 20);
            this.cbghinhomatkhau.TabIndex = 12;
            this.cbghinhomatkhau.Text = "Ghi nhớ mật khẩu";
            this.cbghinhomatkhau.UseVisualStyleBackColor = false;
            // 
            // txtquenmatkhau
            // 
            this.txtquenmatkhau.Location = new System.Drawing.Point(13, 201);
            this.txtquenmatkhau.Name = "txtquenmatkhau";
            this.txtquenmatkhau.Size = new System.Drawing.Size(314, 22);
            this.txtquenmatkhau.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng Nhập Hệ thống";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(13, 128);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(314, 22);
            this.txttendangnhap.TabIndex = 7;
            // 
            // btnquenmatkkhau
            // 
            this.btnquenmatkkhau.Location = new System.Drawing.Point(197, 237);
            this.btnquenmatkkhau.Name = "btnquenmatkkhau";
            this.btnquenmatkkhau.Size = new System.Drawing.Size(130, 23);
            this.btnquenmatkkhau.TabIndex = 13;
            this.btnquenmatkkhau.Text = "Quên Mật khẩu?";
            this.btnquenmatkkhau.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(259, 267);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 16);
            this.linkLabel1.TabIndex = 14;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.Red;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(91, 291);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(158, 36);
            this.btndangnhap.TabIndex = 15;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quan_ly_chi_tieu.Properties.Resources.Screenshot_2025_03_18_134753;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(355, 350);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnquenmatkkhau);
            this.Controls.Add(this.cbghinhomatkhau);
            this.Controls.Add(this.txtquenmatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttendangnhap);
            this.DoubleBuffered = true;
            this.Name = "FrmDangNhap";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbghinhomatkhau;
        private System.Windows.Forms.TextBox txtquenmatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Button btnquenmatkkhau;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btndangnhap;
    }
}

