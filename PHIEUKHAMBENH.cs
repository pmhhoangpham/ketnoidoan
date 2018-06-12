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
    public partial class PHIEUKHAMBENH : Telerik.WinControls.UI.RadForm
    {
        public PHIEUKHAMBENH()
        {
            InitializeComponent();
        }

        int them;

        public class chitietkhambenh
        {
            public static string maphieukhambenh;
            public static string mabenhnhan;
        }

        private void KHAMBENH_Load(object sender, EventArgs e)
        {
            loadbenhnhan();
            loaddanhsachphieukhambenh();
            dinhdangdanhsach();            
            kiemtraquyen();
        }
        public void kiemtraquyen()
        {
            if (DangNhap.bientoancuc.maquyen == "TT")
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
            txtmaphieukhambenh.Enabled = val;
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

        public void loaddanhsachphieukhambenh()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select p.MaPhieuKhamBenh, h.TenBenhNhan, p.NgayKhamBenh From PhieuKhamBenh p, HoSoBenhNhan h Where p.MaBenhNhan = h.MaBenhNhan");
            danhsachphieukhambenh.DataSource = dt;
        }

        public void dinhdangdanhsach()
        {
            danhsachphieukhambenh.Columns[0].HeaderText = "Mã";
            danhsachphieukhambenh.Columns[0].Width = 150;
            danhsachphieukhambenh.Columns[1].HeaderText = "Bệnh Nhân";
            danhsachphieukhambenh.Columns[1].Width = 350;
            danhsachphieukhambenh.Columns[2].HeaderText = "Ngày Khám";
            danhsachphieukhambenh.Columns[2].Width = 250;
        }

        private void danhsachkhambenh_SelectionChanged(object sender, EventArgs e)
        {
            txtmaphieukhambenh.Text = this.danhsachphieukhambenh.CurrentRow.Cells[0].Value.ToString();
            combenhnhan.Text = this.danhsachphieukhambenh.CurrentRow.Cells[1].Value.ToString();
            dtngaykham.Text = this.danhsachphieukhambenh.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);            
            duocnhap(true);
            txtmaphieukhambenh.Focus();
            danhsachphieukhambenh.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            txtmaphieukhambenh.Focus();
            danhsachphieukhambenh.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete PhieuKhamBenh Where MaPhieuKhamBenh = '" + this.danhsachphieukhambenh.CurrentRow.Cells[0].Value.ToString() + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loaddanhsachphieukhambenh();
                    setnut(true);
                    danhsachphieukhambenh.Enabled = true;
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

                if (txtmaphieukhambenh.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into PhieuKhamBenh Values ('"+txtmaphieukhambenh.Text+"', '"+ dtngaykham.Text.ToString() + "', '"+combenhnhan.SelectedValue.ToString()+"')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loaddanhsachphieukhambenh();
                        setnut(true);
                        danhsachphieukhambenh.Enabled = true;
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
                if (txtmaphieukhambenh.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update PhieuKhamBenh Set MaPhieuKhamBenh ='"+txtmaphieukhambenh.Text+"', NgayKhamBenh ='"+dtngaykham.Text.ToString()+"', MaBenhNhan ='"+combenhnhan.SelectedValue.ToString() +"' Where MaPhieuKhamBenh ='" + this.danhsachphieukhambenh.CurrentRow.Cells[0].Value.ToString() + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        loaddanhsachphieukhambenh();
                        setnut(true);
                        danhsachphieukhambenh.Enabled = true;
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
            danhsachphieukhambenh.Enabled = true;
            duocnhap(false);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhsachphieukhambenh_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {           
            chitietkhambenh.maphieukhambenh = danhsachphieukhambenh.CurrentRow.Cells[0].Value.ToString();
            chitietkhambenh.mabenhnhan = danhsachphieukhambenh.CurrentRow.Cells[1].Value.ToString();
            CHITIETKHAMBENH ctkb = new CHITIETKHAMBENH();
            ctkb.Show();
        }
    }
}
