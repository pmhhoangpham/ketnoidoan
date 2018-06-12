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
    public partial class CHITIETXETNGHIEM : Telerik.WinControls.UI.RadForm
    {
        public CHITIETXETNGHIEM()
        {
            InitializeComponent();
        }

        private void CHITIETXETNGHIEM_Load(object sender, EventArgs e)
        {
            lbmaxetnghiem.Text = PHIEUXETNGHIEM.chitietxetnghiem.maphieuxetnghiem.ToUpper();
            ltenbenhnhan.Text = PHIEUXETNGHIEM.chitietxetnghiem.mabenhnhan.ToUpper();
            loadchitietxetnghiem();
            kiemtraquyen();
            dinhdangdanhsach();
            loadxetnghiem();                
            btncapnhat.Enabled = false;
            tinhtien();
        }

        public void kiemtraquyen()
        {
            if(DangNhap.bientoancuc.maquyen == "BS")
            {
                setnut(true);
                duocnhap(false);
                loadbascsi();
            }
            else
            {
                duocnhap(false);
                btnthem.Enabled = false;
                btnluu.Enabled = false;
                btnxoa.Enabled = false;
                btnhuy.Enabled = false;
                btnluu.Enabled = false;
            }
        }

        void setnut(bool val)
        {
            btnthem.Enabled = val;            
            btnluu.Enabled = !val;
            btnxoa.Enabled = val;
            btnhuy.Enabled = !val;
            btnluu.Enabled = !val;
        }

        void xoatext()
        {
            txtketqua.Clear();

        }

        void duocnhap(bool val)
        {
           // combacsi.Enabled = val;
            comxetnghiem.Enabled = val;
            txtketqua.Enabled = val;
        }



        public void loadchitietxetnghiem()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select x.TenXetNghiem, c.KetQuaXetNghiem, b.TenBacSi, x.DonGia From XetNghiem x, BacSi b, ChiTietXetNghiem c Where x.MaXetNghiem = c.MaXetNghiem And b.MaBacSi = c.MaBacSi And c.MaPhieuXetNghiem = '"+PHIEUXETNGHIEM.chitietxetnghiem.maphieuxetnghiem.ToString()+"'");
            danhsachxetnghiem.DataSource = dt;
        }

        public void loadxetnghiem()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaXetNghiem, TenXetNghiem From XetNghiem");
            comxetnghiem.DataSource = dt;
            comxetnghiem.DisplayMember = "TenXetNghiem";
            comxetnghiem.ValueMember = "MaXetNghiem";
            comxetnghiem.Columns[0].HeaderText = "Mã Xét Nghiệm";
            comxetnghiem.Columns[0].Width = 110;
            comxetnghiem.Columns[1].HeaderText = "Tên Xét Nghiệm";
            comxetnghiem.Columns[1].Width = 230;
        }

        public void loadbascsi()
        {/*
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaBacSi, TenBacSi From BacSi");
            combacsi.DataSource = dt;
            combacsi.DisplayMember = "TenBacSi";
            combacsi.ValueMember = "MaBacSi";
            combacsi.Columns[0].HeaderText = "Mã Bác Sĩ";
            combacsi.Columns[0].Width = 110;
            combacsi.Columns[1].HeaderText = "Tên Bác Sĩ";
            combacsi.Columns[1].Width = 230;
            */
            lbbacsi.Text = DangNhap.bientoancuc.tennguoidung.ToUpper();
        }


        public void dinhdangdanhsach()
        {
            danhsachxetnghiem.Columns[0].HeaderText = "Xét Nghiệm";
            danhsachxetnghiem.Columns[0].Width = 275;
            danhsachxetnghiem.Columns[1].HeaderText = "Kết Quả";
            danhsachxetnghiem.Columns[1].Width = 275;
            danhsachxetnghiem.Columns[2].HeaderText = "Bac Sĩ";
            danhsachxetnghiem.Columns[2].Width = 150;
            danhsachxetnghiem.Columns[3].HeaderText = "Đơn Giá";
            danhsachxetnghiem.Columns[3].Width = 50;
        }

        private void danhsachxetnghiem_SelectionChanged(object sender, EventArgs e)
        {
            comxetnghiem.Text = this.danhsachxetnghiem.CurrentRow.Cells[0].Value.ToString();
            txtketqua.Text = this.danhsachxetnghiem.CurrentRow.Cells[1].Value.ToString();
            //combacsi.Text = this.danhsachxetnghiem.CurrentRow.Cells[2].Value.ToString();
        }

        
        private void btnthem_Click(object sender, EventArgs e)
        {           
            setnut(false);
            xoatext();
            duocnhap(true);
            comxetnghiem.Focus();
            danhsachxetnghiem.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete From ChiTietXetNghiem Where MaPhieuXetNghiem = '" + PHIEUXETNGHIEM.chitietxetnghiem.maphieuxetnghiem.ToString() + "' And MaXetNghiem ='" + comxetnghiem.SelectedValue.ToString() + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loadchitietxetnghiem();
                    setnut(true);
                    danhsachxetnghiem.Enabled = true;
                    duocnhap(false);
                    tinhtien();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtketqua.Text != "")
            {
                KetNoi z = new KetNoi();
                int kq = z.xulydulieu("Insert Into ChiTietXetNghiem Values ('" + PHIEUXETNGHIEM.chitietxetnghiem.maphieuxetnghiem.ToString() + "', '" + comxetnghiem.SelectedValue.ToString() + "', N'" + txtketqua.Text + "', '" + DangNhap.bientoancuc.mabs.ToString() + "')");
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loadchitietxetnghiem();
                    setnut(true);
                    danhsachxetnghiem.Enabled = true;
                    duocnhap(false);
                    tinhtien();
                }
                else
                {
                    MessageBox.Show("Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa đủ thông tin. Vui lòng kiểm tra lại");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setnut(true);
            danhsachxetnghiem.Enabled = true;
            duocnhap(false);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void tinhtien()
        {
            Decimal tong = 0;
            for (int i = 0; i < Convert.ToInt32(danhsachxetnghiem.Rows.Count.ToString()); i++)
            {
                tong = tong + ((Convert.ToDecimal(danhsachxetnghiem.Rows[i].Cells[3].Value.ToString())));
            }
            ltongtien.Text = tong.ToString() + " VNĐ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
