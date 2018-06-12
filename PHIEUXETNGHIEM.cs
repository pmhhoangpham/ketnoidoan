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
    public partial class PHIEUXETNGHIEM : Telerik.WinControls.UI.RadForm
    {
        public PHIEUXETNGHIEM()
        {
            InitializeComponent();
        }


        private void PHIEUXETNGHIEM_Load(object sender, EventArgs e)
        {
            loadbenhnhan();
            loaddanhsachphieuxetnghiem();
            dinhdangdanhsach();
            kiemtraquyen();
        }

        public void kiemtraquyen()
        {
            if(DangNhap.bientoancuc.maquyen == "TT")
            {
                setnut(true);
                duocnhap(false);
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


        void duocnhap(bool val)
        {
            txtmaphieuxetnghiem.Enabled = val;
            combenhnhan.Enabled = val;
            dtngaykham.Enabled = val;
        }

        public void loadbenhnhan()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaBenhNhan, TenBenhNhan From HoSoBenhNhan");
            combenhnhan.DataSource = dt;
            combenhnhan.DisplayMember = "TenBenhNhan";
            combenhnhan.ValueMember = "MaBenhNhan";
            combenhnhan.Columns[0].HeaderText = "Mã BN";
            combenhnhan.Columns[0].Width = 110;
            combenhnhan.Columns[1].HeaderText = "Tên Bệnh Nhân";
            combenhnhan.Columns[1].Width = 230;
        }

        public void loaddanhsachphieuxetnghiem()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select x.MaPhieuXetNghiem, n.TenBenhNhan, x.NgayXetNghiem From PhieuXetNghiem x, HoSoBenhNhan n Where x.MaBenhNhan = n.MaBenhNhan");
            danhsachphieuxetnghiem.DataSource = dt;
        }

        public void dinhdangdanhsach()
        {
            danhsachphieuxetnghiem.Columns[0].HeaderText = "Mã";
            danhsachphieuxetnghiem.Columns[0].Width = 150;
            danhsachphieuxetnghiem.Columns[1].HeaderText = "Bệnh Nhân";
            danhsachphieuxetnghiem.Columns[1].Width = 350;
            danhsachphieuxetnghiem.Columns[2].HeaderText = "Ngày Xét Nghiệm";
            danhsachphieuxetnghiem.Columns[2].Width = 250;
        }

        private void danhsachphieuxetnghiem_SelectionChanged(object sender, EventArgs e)
        {
            txtmaphieuxetnghiem.Text = this.danhsachphieuxetnghiem.CurrentRow.Cells[0].Value.ToString();
            combenhnhan.Text = this.danhsachphieuxetnghiem.CurrentRow.Cells[1].Value.ToString();
            dtngaykham.Text = this.danhsachphieuxetnghiem.CurrentRow.Cells[2].Value.ToString();
        }

        int them;
        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);
            duocnhap(true);
            txtmaphieuxetnghiem.Focus();
            danhsachphieuxetnghiem.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            txtmaphieuxetnghiem.Focus();
            danhsachphieuxetnghiem.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete PhieuXetNghiem Where MaPhieuXetNghiem ='" + txtmaphieuxetnghiem.Text + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loaddanhsachphieuxetnghiem();
                    setnut(true);
                    danhsachphieuxetnghiem.Enabled = true;
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

                if (txtmaphieuxetnghiem.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into PhieuXetNghiem Values ('" + txtmaphieuxetnghiem.Text + "', '" + dtngaykham.Text.ToString() + "', '" + combenhnhan.SelectedValue.ToString() + "')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loaddanhsachphieuxetnghiem();
                        setnut(true);
                        danhsachphieuxetnghiem.Enabled = true;
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
                if (txtmaphieuxetnghiem.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update PhieuXetNghiem Set MaPhieuXetNghiem ='" + txtmaphieuxetnghiem.Text + "', NgayXetNghiem ='" + dtngaykham.Text.ToString() + "',MaBenhNhan ='" + combenhnhan.SelectedValue.ToString() + "' Where MaPhieuXetNghiem ='" + this.danhsachphieuxetnghiem.CurrentRow.Cells[0].Value.ToString() + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        loaddanhsachphieuxetnghiem();
                        setnut(true);
                        danhsachphieuxetnghiem.Enabled = true;
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
            danhsachphieuxetnghiem.Enabled = true;
            duocnhap(false);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class chitietxetnghiem
        {
            public static string maphieuxetnghiem;
            public static string mabenhnhan;
        }
        private void danhsachphieuxetnghiem_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            chitietxetnghiem.maphieuxetnghiem = this.danhsachphieuxetnghiem.CurrentRow.Cells[0].Value.ToString();
            chitietxetnghiem.mabenhnhan = this.danhsachphieuxetnghiem.CurrentRow.Cells[1].Value.ToString();
            CHITIETXETNGHIEM ctkb = new CHITIETXETNGHIEM();
            ctkb.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

