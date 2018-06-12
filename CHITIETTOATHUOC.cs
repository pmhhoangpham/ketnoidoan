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
    public partial class CHITIETTOATHUOC : Telerik.WinControls.UI.RadForm
    {
        public CHITIETTOATHUOC()
        {
            InitializeComponent();
        }

        private void CHITIETTOATHUOC_Load(object sender, EventArgs e)
        {
            lmatoa.Text = TOATHUOC.chitiettoathuoc.matoathuoc.ToUpper();
            loadtenbenhnhan();
            loadchitiettoathuoc();
            dinhdangdanhsach();
            loadthuoc();
            tinhtien();
            kiemtraquyen();
        }

        public void kiemtraquyen()
        {
            if (DangNhap.bientoancuc.maquyen == "BS")
            {
                setnut(true);
                duocnhap(false);
                lbbacsi.Text = DangNhap.bientoancuc.tennguoidung.ToUpper();
            }
            else
            {
                duocnhap(false);
                btnthem.Enabled = false;
                btncapnhat.Enabled = false;
                btnluu.Enabled = false;
                btnxoa.Enabled = false;
                btnhuy.Enabled = false;
                btnluu.Enabled = false;
            }
        }

        void setnut(bool val)
        {
            btnthem.Enabled = val;
            btncapnhat.Enabled = val;
            btnluu.Enabled = !val;
            btnxoa.Enabled = val;
            btnhuy.Enabled = !val;
            btnluu.Enabled = !val;
        }

        void xoatext()
        {
            numsl.Value = 1;

        }

        void duocnhap(bool val)
        {
            comthuoc.Enabled = val;
            numsl.Enabled = val;
        }

        public void loadtenbenhnhan()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select TenBenhNhan From HoSoBenhNhan,     (Select MaBenhNhan    From PhieuKhamBenh    Where MaPhieuKhamBenh = '" + TOATHUOC.chitiettoathuoc.makhambenh.ToString() + "') as Q1 Where Q1.MaBenhNhan = HoSoBenhNhan.MaBenhNhan");
            DataRow r = dt.Rows[0];
            ltenbenhnhan.Text = r["TenBenhNhan"].ToString().ToUpper();
        }


        public void loadchitiettoathuoc()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select t.TenThuoc, t.CachSuDung, c.SoLuongThuoc, t.DonGia From ChiTietToaThuoc c, Thuoc t Where c.MaThuoc = t.MaThuoc And c.MaToaThuoc = '" + TOATHUOC.chitiettoathuoc.matoathuoc.ToString() + "'");
            danhsachthuoc.DataSource = dt;
        }

        public void loadthuoc()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaThuoc, TenThuoc From Thuoc");
            comthuoc.DataSource = dt;
            comthuoc.DisplayMember = "TenThuoc";
            comthuoc.ValueMember = "MaThuoc";
            comthuoc.Columns[0].HeaderText = "Mã Thuốc";
            comthuoc.Columns[0].Width = 110;
            comthuoc.Columns[1].HeaderText = "Tên Thuốc";
            comthuoc.Columns[1].Width = 230;
        }

        public void dinhdangdanhsach()
        {
            danhsachthuoc.Columns[0].HeaderText = "Tên Thuốc";
            danhsachthuoc.Columns[0].Width = 275;
            danhsachthuoc.Columns[1].HeaderText = "Cách Sử Dụng";
            danhsachthuoc.Columns[1].Width = 275;
            danhsachthuoc.Columns[2].HeaderText = "SL";
            danhsachthuoc.Columns[2].Width = 95;
            danhsachthuoc.Columns[3].HeaderText = "Đơn Giá";
            danhsachthuoc.Columns[3].Width = 95;

        }

        private void danhsachthuoc_SelectionChanged(object sender, EventArgs e)
        {
            comthuoc.Text = this.danhsachthuoc.CurrentRow.Cells[0].Value.ToString();
            numsl.Text = this.danhsachthuoc.CurrentRow.Cells[2].Value.ToString();
        }

        int them;
        private void btnthem_Click(object sender, EventArgs e)
        {
            numsl.Value = 1;
            them = 1;
            setnut(false);
            xoatext();
            duocnhap(true);
            comthuoc.Focus();
            danhsachthuoc.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            comthuoc.Focus();
            danhsachthuoc.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete ChiTietToaThuoc Where MaToaThuoc = '" + TOATHUOC.chitiettoathuoc.matoathuoc.ToString() + "' And MaThuoc = '" + comthuoc.SelectedValue.ToString() + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loadchitiettoathuoc();
                    setnut(true);
                    danhsachthuoc.Enabled = true;
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
            if (them == 1)
            {
                //====================================== Thêm mới ====================================== 
                if (numsl.Value > 0)
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into ChiTietToaThuoc Values ('" + TOATHUOC.chitiettoathuoc.matoathuoc.ToString() + "', '" + comthuoc.SelectedValue.ToString() + "', '" + Convert.ToInt32(numsl.Value.ToString()) + "')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loadchitiettoathuoc();
                        setnut(true);
                        danhsachthuoc.Enabled = true;
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
            //====================================== Chỉnh sửa ====================================== 

            else
            {
                if (numsl.Value > 0)
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update ChiTietToaThuoc Set MaThuoc ='" + comthuoc.SelectedValue.ToString() + "', SoLuongThuoc= '" + Convert.ToInt32(numsl.Value.ToString()) + "' Where MaToaThuoc ='" + TOATHUOC.chitiettoathuoc.matoathuoc.ToString() + "' And TenThuoc ='" + this.danhsachthuoc.CurrentRow.Cells[0].Value.ToString() + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        loadchitiettoathuoc();
                        setnut(true);
                        danhsachthuoc.Enabled = true;
                        duocnhap(false);
                        tinhtien();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa đủ thông tin. Vui lòng kiểm tra lại");
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setnut(true);
            danhsachthuoc.Enabled = true;
            duocnhap(false);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void tinhtien()
        {
            Decimal tong = 0;
            for (int i = 0; i < Convert.ToInt32(danhsachthuoc.Rows.Count.ToString()); i++)
            {
                tong = tong + ((Convert.ToDecimal(danhsachthuoc.Rows[i].Cells[3].Value.ToString())) * (Convert.ToDecimal(danhsachthuoc.Rows[i].Cells[2].Value.ToString())));
            }
            ltongtien.Text = tong.ToString() + " VNĐ";
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
