using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhamChuaBenh
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public class bientoancuc
        {
            public static string tennguoidung;
            public static string maquyen;
            public static string mabs;

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            DataTable nguoidung = new DataTable();
            nguoidung = kn.laybang("Select * From TaiKhoan Where TenDangNhap ='"+txtdangnhap.Text+"' And MatKhau ='"+txtmatkhau.Text+"'");
            if (nguoidung.Rows.Count == 1)
            {
                DataRow r = nguoidung.Rows[0];
                DataTable taikhoan = new DataTable();
                bientoancuc.tennguoidung = r[2].ToString();
                bientoancuc.maquyen = r[4].ToString();
                bientoancuc.mabs = r[5].ToString();
                MessageBox.Show("Chúc Mừng " + "'" + r[2].ToString().ToUpper() + "'" + " Đã Đăng Nhập Thành Công");
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công. Vui Lòng Thử Lại");
                txtmatkhau.Clear();
                txtdangnhap.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtdangnhap.Focus();
        }
    }
}
