using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace QLKhamChuaBenh
{
    public partial class BAOCAO_THONGKE : Telerik.WinControls.UI.RadForm
    {
        public BAOCAO_THONGKE()
        {
            InitializeComponent();            
        }

        private void BAOCAO_THONGKE_Load(object sender, EventArgs e)
        {
            loaddanhsachbenhnhan();
            dinhdangdanhsachbenhnhan();
            laynam();            
            loaddanhsachkhambenh();
            dinhdangdanhsachkhambenh();
            loaddanhsachxetnghiem();
            dinhdangdanhsachxetnghiem();
        }

        //tab 1

        public void laynam()
        {
            for (int i = 1950; i <= DateTime.Now.Year; i++)
            {
               comnambenhnhan.Items.Add(i);
            }
            
        }

        public void loaddanhsachbenhnhan()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From HoSoBenhNhan");
            danhsachbenhnhan.DataSource = dt;
        }

        public void loaddanhsachbenhnhan1()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From HoSoBenhNhan Where NgaySinhBenhNhan like '%" + comnambenhnhan.Text.ToString() + "%' ");
            danhsachbenhnhan.DataSource = dt;
        }

        public void loaddanhsachbenhnhan2()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From HoSoBenhNhan Where DiaChiBenhNhan like N'%" + txtbenhnhantinh.Text+ "%' ");
            danhsachbenhnhan.DataSource = dt;
        }

        public void loaddanhsachbenhnhan3()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From HoSoBenhNhan Where TenBenhNhan like N'%" + txtbenhnhanten.Text + "%' ");
            danhsachbenhnhan.DataSource = dt;
        }


        public void dinhdangdanhsachbenhnhan()
        {
            danhsachbenhnhan.Columns[0].HeaderText = "Mã";
            danhsachbenhnhan.Columns[0].Width = 75;
            danhsachbenhnhan.Columns[1].HeaderText = "Tên Bệnh Nhân";
            danhsachbenhnhan.Columns[1].Width = 200;
            danhsachbenhnhan.Columns[2].HeaderText = "Giới Tính";
            danhsachbenhnhan.Columns[2].Width = 80;
            danhsachbenhnhan.Columns[3].HeaderText = "Ngày Sinh";
            danhsachbenhnhan.Columns[3].Width = 80;
            danhsachbenhnhan.Columns[4].HeaderText = "Dịa Chỉ";
            danhsachbenhnhan.Columns[4].Width = 200;
            danhsachbenhnhan.Columns[5].HeaderText = "SĐT";
            danhsachbenhnhan.Columns[5].Width = 80;
            danhsachbenhnhan.Columns[6].HeaderText = "CMND";
            danhsachbenhnhan.Columns[6].Width = 80;
            danhsachbenhnhan.Columns[7].HeaderText = "Ghi Chú";
            danhsachbenhnhan.Columns[7].Width = 150;            
        }

        private void comnambenhnhan_TextChanged(object sender, EventArgs e)
        {
            loaddanhsachbenhnhan1();
        }


        private void txtbenhnhantinh_TextChanged(object sender, EventArgs e)
        {         
            loaddanhsachbenhnhan2();
        }

        private void txtbenhnhanten_TextChanged(object sender, EventArgs e)
        {
           
            loaddanhsachbenhnhan3();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtbenhnhanten_Enter(object sender, EventArgs e)
        {
            if (txtbenhnhanten.Text.Trim() != "" || txtbenhnhanten.Text != null)
            {
                txtbenhnhanten.Text = "";
                txtbenhnhantinh.Text = "Nhập địa chỉ bệnh nhân";
            }
        }

        private void txtbenhnhantinh_Enter(object sender, EventArgs e)
        {
            if (txtbenhnhantinh.Text.Trim() != "" || txtbenhnhantinh.Text != null)
            {
                txtbenhnhantinh.Text = "";
                txtbenhnhanten.Text = "Nhập tên bệnh nhân";
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            txtbenhnhanten.Text = "";
            txtbenhnhantinh.Text = "";
            comnambenhnhan.Text = "";
            loaddanhsachbenhnhan();
        }



        //tab 2

        public void loaddanhsachkhambenh()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select p.MaPhieuKhamBenh,n.TenBenhNhan, s.TenBacSi, b.TenBenh, c.TrieuChung, p.NgayKhamBenh From PhieuKhamBenh p, ChiTietKhamBenh c, HoSoBenhNhan n, BacSi s, Benh b Where p.MaPhieuKhamBenh = c.MaPhieuKhamBenh And n.MaBenhNhan = p.MaBenhNhan And s.MaBacSi = c.MaBacSi And b.MaBenh = c.MaBenh And NgayKhamBenh = '" + dtkhambenh.Text.ToString() + "'");
            danhsachkhambenh.DataSource = dt;
        }

        public void dinhdangdanhsachkhambenh()
        {
            danhsachkhambenh.Columns[0].HeaderText = "Mã Phiếu";
            danhsachkhambenh.Columns[0].Width = 100;
            danhsachkhambenh.Columns[1].HeaderText = "Bệnh Nhân";
            danhsachkhambenh.Columns[1].Width = 200;
            danhsachkhambenh.Columns[2].HeaderText = "Bác Sĩ";
            danhsachkhambenh.Columns[2].Width = 200;
            danhsachkhambenh.Columns[3].HeaderText = "Bệnh";
            danhsachkhambenh.Columns[3].Width = 100;
            danhsachkhambenh.Columns[4].HeaderText = "Triệu Chứng";
            danhsachkhambenh.Columns[4].Width = 160;
            danhsachkhambenh.Columns[5].HeaderText = "Ngày Khám";
            danhsachkhambenh.Columns[5].Width = 80;         
        }

        private void dtkhambenh_ValueChanged(object sender, EventArgs e)
        {
            loaddanhsachkhambenh();
        }


        //tab 3

        public void loaddanhsachxetnghiem()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select p.MaPhieuXetNghiem, n.TenBenhNhan, s.TenBacSi, b.TenXetNghiem, c.KetQuaXetNghiem, p.NgayXetNghiem From PhieuXetNghiem p, ChiTietXetNghiem c, HoSoBenhNhan n, BacSi s, XetNghiem b Where p.MaPhieuXetNghiem = c.MaPhieuXetNghiem And n.MaBenhNhan = p.MaBenhNhan And s.MaBacSi = c.MaBacSi And b.MaXetNghiem = c.MaXetNghiem And NgayXetNghiem = '" + dtngayxetnghiem.Text.ToString() + "'");
            danhsachxetnghiem.DataSource = dt;
        }

        public void dinhdangdanhsachxetnghiem()
        {
            danhsachxetnghiem.Columns[0].HeaderText = "Mã Phiếu";
            danhsachxetnghiem.Columns[0].Width = 100;
            danhsachxetnghiem.Columns[1].HeaderText = "Bệnh Nhân";
            danhsachxetnghiem.Columns[1].Width = 200;
            danhsachxetnghiem.Columns[2].HeaderText = "Bác Sĩ";
            danhsachxetnghiem.Columns[2].Width = 200;
            danhsachxetnghiem.Columns[3].HeaderText = "Xét Nghiệm";
            danhsachxetnghiem.Columns[3].Width = 200;
            danhsachxetnghiem.Columns[4].HeaderText = "Kết Quả";
            danhsachxetnghiem.Columns[4].Width = 160;
            danhsachxetnghiem.Columns[5].HeaderText = "Ngày";
            danhsachxetnghiem.Columns[5].Width = 80;
        }

        private void dtngayxetnghiem_ValueChanged(object sender, EventArgs e)
        {
            loaddanhsachxetnghiem();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
