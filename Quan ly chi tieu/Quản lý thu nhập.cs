using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Quanlychitieu;
using DAL_Quanlychitieu;

namespace Quan_ly_chi_tieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtsotien.Enabled = true;
            txtghichu.Enabled = true;
            txtTimkiem.Enabled = true;
            txtMathunhap.Enabled = true;
            dtpngayghinhan.Enabled = true;
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int maThuNhap = int.Parse(txtMathunhap.Text);
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //do something if YES
                if (busThuNhap.DeleteHang(maThuNhap))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValues();
                    LoadGridview_ThuNhap(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                //do something if NO
                ResetValues();
            }
        }
        private void LoadGridview_Hang()
        {
            DGVquanlythunhap.DataSource = busThuNhap.getThuNhap();
            DGVquanlythunhap.Columns[0].HeaderText = "Mã Thu Nhập";
            DGVquanlythunhap.Columns[1].HeaderText = "Tên Sản Phẩm";
            DGVquanlythunhap.Columns[2].HeaderText = "Số tiền";
            DGVquanlythunhap.Columns[3].HeaderText = "Ghi chú";
        }
        private void ResetValues()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtsotien.Enabled = true;
            txtghichu.Enabled = true;
            txtTimkiem.Enabled = true;
            txtMathunhap.Enabled = true;
            dtpngayghinhan.Enabled = true;
        }
        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            string tenHang = txtTimkiem.Text;
            DataTable ds = busThuNhap.SearchHang(tenHang);
            if (ds.Rows.Count > 0)
            {
                DGVquanlythunhap.DataSource = busThuNhap.getThuNhap();
                DGVquanlythunhap.Columns[0].HeaderText = "Mã Thu Nhập";
                DGVquanlythunhap.Columns[1].HeaderText = "Tên Sản Phẩm";
                DGVquanlythunhap.Columns[2].HeaderText = "Số tiền";
                DGVquanlythunhap.Columns[3].HeaderText = "Ghi chú";
            }
            else
            {
                MessageBox.Show("Không tìm thấy san pham", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimkiem.Text = "Nhập mã sản phẩm";
            txtTimkiem.BackColor = Color.LightGray;
            ResetValues();
        }
        private void TxttimKiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = null;
            txtTimkiem.BackColor = Color.White;
        }
    }
   }