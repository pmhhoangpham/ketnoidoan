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
    public partial class CHITIETKHAMBENH : Telerik.WinControls.UI.RadForm
    {
        public CHITIETKHAMBENH()
        {
            InitializeComponent();
        }

        string makhambenh = PHIEUKHAMBENH.chitietkhambenh.maphieukhambenh.ToString();
        string mabenhnhan = PHIEUKHAMBENH.chitietkhambenh.mabenhnhan.ToString();
        string mabenh;
        string mabs = DangNhap.bientoancuc.mabs.ToString();

        private void CHITIETKHAMBENH_Load(object sender, EventArgs e)
        {
            loadtenbenhnhan();
            lmaphieu.Text = makhambenh;
            loadbenh();
            loaddanhsachbenh();
            dinhdangdanhsach();
            kiemtraquyen();
            btncapnhat.Enabled = false;
        }

        public void kiemtraquyen()
        {
            if (DangNhap.bientoancuc.maquyen == "BS")
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

        public void loadbascsi()
        {
            lbbacsi.Text = DangNhap.bientoancuc.tennguoidung.ToUpper();
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
            txtrieuchung.Clear();

        }

        void duocnhap(bool val)
        {
            combenh.Enabled = val;
            txtrieuchung.Enabled = val;
        }

        public void loadtenbenhnhan()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select TenBenhNhan From HoSoBenhNhan Where TenBenhNhan =N'" + mabenhnhan + "'");
            DataRow r = dt.Rows[0];
            ltenbenhnhan.Text = r["TenBenhNhan"].ToString().ToUpper();
        }

        public void loadbenh()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaBenh, TenBenh From Benh");
            combenh.DataSource = dt;
            combenh.DisplayMember = "TenBenh";
            combenh.ValueMember = "MaBenh";
            combenh.Columns[0].HeaderText = "Mã Bệnh";
            combenh.Columns[0].Width = 110;
            combenh.Columns[1].HeaderText = "Tên Bệnh";
            combenh.Columns[1].Width = 230;
        }


        public void loaddanhsachbenh()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select b.TenBenh, bs.TenBacSi, kb.TrieuChung From ChiTietKhamBenh kb, Benh b, BacSi bs Where kb.MaBenh = b.MaBenh And kb.MaBacSi = bs.MaBacSi And kb.MaPhieuKhamBenh = '" + makhambenh + "'");
            danhsachbenh.DataSource = dt;
        }

        private void danhsachbenh_SelectionChanged(object sender, EventArgs e)
        {
            txtrieuchung.Text = this.danhsachbenh.CurrentRow.Cells[2].Value.ToString();
            combenh.Text = this.danhsachbenh.CurrentRow.Cells[0].Value.ToString();
        }

        public void dinhdangdanhsach()
        {
            danhsachbenh.Columns[0].HeaderText = "Bệnh";
            danhsachbenh.Columns[0].Width = 165;
            danhsachbenh.Columns[1].HeaderText = "Bác Sĩ";
            danhsachbenh.Columns[1].Width = 300;
            danhsachbenh.Columns[2].HeaderText = "Triệu Chứng";
            danhsachbenh.Columns[2].Width = 300;
        }

        int them;
        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);
            xoatext();
            duocnhap(true);
            combenh.Focus();
            danhsachbenh.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            combenh.Focus();
            danhsachbenh.Enabled = false;
            mabenh = combenh.SelectedValue.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete ChiTietKhamBenh Where MaPhieuKhamBenh = '" + makhambenh + "' And MaBenh ='" + combenh.SelectedValue.ToString() + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loaddanhsachbenh();
                    setnut(true);
                    danhsachbenh.Enabled = true;
                    duocnhap(false);
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

                if (txtrieuchung.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into ChiTietKhamBenh Values ('" + makhambenh + "', '" + combenh.SelectedValue.ToString() + "', '" + mabs + "', N'" + txtrieuchung.Text + "')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loaddanhsachbenh();
                        setnut(true);
                        danhsachbenh.Enabled = true;
                        duocnhap(false);
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
                if (txtrieuchung.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update ChiTietKhamBenh Set MaBenh ='" + combenh.SelectedValue.ToString() + "', MaBacSi ='" + mabs + "', TrieuChung =N'" + txtrieuchung.Text + "' Where MaPhieuKhamBenh ='" + makhambenh + "' And MaBenh = '" + mabenh + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        loaddanhsachbenh();
                        setnut(true);
                        danhsachbenh.Enabled = true;
                        duocnhap(false);
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
            danhsachbenh.Enabled = true;
            duocnhap(false);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
