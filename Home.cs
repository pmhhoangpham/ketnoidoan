using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKhamChuaBenh
{
    public partial class Home : Telerik.WinControls.UI.RadRibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void RadRibbonForm1_Load(object sender, EventArgs e)
        {
            txttendangnhap.Text = DangNhap.bientoancuc.tennguoidung.ToString();
            phanquyen();
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            BENH b = new BENH();
            b.Show();
        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            XETNGHIEM xn = new XETNGHIEM();
            xn.Show();
        }

        private void radButtonElement7_Click(object sender, EventArgs e)
        {
            BENHNHAN bn = new BENHNHAN();
            bn.Show();
        }
        

        private void radRibbonBarGroup6_Click(object sender, EventArgs e)
        {

        }

        private void radButtonElement8_Click(object sender, EventArgs e)
        {
            NHACCUNGCAP ncc = new NHACCUNGCAP();
            ncc.Show();
        }

        private void radButtonElement9_Click(object sender, EventArgs e)
        {
            Thuoc t = new Thuoc();
            t.Show();
        }

        private void radButtonElement10_Click(object sender, EventArgs e)
        {
            PHIEUKHAMBENH kb = new PHIEUKHAMBENH();
            kb.Show();
        }

        private void radButtonElement11_Click(object sender, EventArgs e)
        {
            BACSI bs = new BACSI();
            bs.Show();
        }

        private void radButtonElement4_Click_1(object sender, EventArgs e)
        {
            XETNGHIEM xn = new XETNGHIEM();
            xn.Show();
        }

        private void radButtonElement12_Click(object sender, EventArgs e)
        {
            TOATHUOC TT = new TOATHUOC();
            TT.Show();
        }

        private void radButtonElement15_Click(object sender, EventArgs e)
        {
            PHIEUKHAMBENH pkb = new PHIEUKHAMBENH();
            pkb.Show();
        }

        private void radButtonElement14_Click(object sender, EventArgs e)
        {
            PHIEUXETNGHIEM pxn = new PHIEUXETNGHIEM();
            pxn.Show();
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }

        private void radButtonElement13_Click(object sender, EventArgs e)
        {
            BACSI bs = new BACSI();
            bs.Show();
        }

       

        public void phanquyen()
        {
            if(DangNhap.bientoancuc.maquyen == "BS")
            {
                btnbenh.Enabled = false;
                btnxetnghiem.Enabled = false;
                btnbacsi.Enabled = false;
                btnbenhnhan.Enabled = false;
                btnthuoc.Enabled = false;
                btnnhacungcap.Enabled = false;
                btndatthuoc.Enabled = false;                
            }
            if(DangNhap.bientoancuc.maquyen == "TT")
            {
                btnbenh.Enabled = false;
                btnxetnghiem.Enabled = false;
                btnbacsi.Enabled = false;                
                btnthuoc.Enabled = false;
                btnnhacungcap.Enabled = false;
                btndatthuoc.Enabled = false;

            }
            if (DangNhap.bientoancuc.maquyen == "QL")
            {
                btnbenhnhan.Enabled = false;
                btnphieukhambenh.Enabled = false;
                btnphieuxetnghiem.Enabled = false;
                btntoathuoc.Enabled = false;                
            }
        }

        private void radButtonElement1_Click_1(object sender, EventArgs e)
        {
            BAOCAO_THONGKE bc = new BAOCAO_THONGKE();
            bc.Show();
        }

        private void radButtonElement4_Click_2(object sender, EventArgs e)
        {
            BAOCAO_THONGKE_VIENPHI VP = new BAOCAO_THONGKE_VIENPHI();
            VP.Show();
        }
    }
}
