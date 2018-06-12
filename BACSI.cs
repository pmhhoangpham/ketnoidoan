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
    public partial class BACSI : Telerik.WinControls.UI.RadForm
    {
        public BACSI()
        {
            InitializeComponent();
        }

        int them;

        private void BACSI_Load(object sender, EventArgs e)
        {
            loadkhoa();
            setnut(true);
            duocnhap(false);
            loaddanhsachbacsi();
            dinhdangdanhsach();
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
            txtghichu.Clear();
            txttenbacsi.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            txtcmnd.Clear();

        }

        void duocnhap(bool val)
        {
            txtghichu.Enabled = val;
            txtmabacsi.Enabled = val;
            txttenbacsi.Enabled = val;
            txtdiachi.Enabled = val;
            txtsdt.Enabled = val;
            txtcmnd.Enabled = val;
            comgioitinh.Enabled = val;
            comkhoa.Enabled = val;
            dtngaysinh.Enabled = val;
        }

        public void loaddanhsachbacsi()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select   bs.MaBacSi, bs.TenBacSi, bs.GioiTinhBacSi, bs.NgaySinhBacSi, bs.DiaChiBacSi, bs.CMNDBacSi, bs.SDTBacSi, k.TenKhoa, bs.GhiChu From BacSi bs, Khoa k Where bs.MaKhoa = k.MaKhoa");
            danhsachbacsi.DataSource = dt;
        }

        public void loadkhoa()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From Khoa");
            comkhoa.DataSource = dt;
            comkhoa.DisplayMember = "TenKhoa";
            comkhoa.ValueMember = "MaKhoa";
        }
        public void dinhdangdanhsach()
        {
            danhsachbacsi.Columns[0].HeaderText = "Mã";
            danhsachbacsi.Columns[0].Width = 75;
            danhsachbacsi.Columns[1].HeaderText = "Tên Bác Sĩ";
            danhsachbacsi.Columns[1].Width = 180;
            danhsachbacsi.Columns[2].HeaderText = "Giới Tính";
            danhsachbacsi.Columns[2].Width = 80;
            danhsachbacsi.Columns[3].HeaderText = "Ngay Sinh";
            danhsachbacsi.Columns[3].Width = 80;
            danhsachbacsi.Columns[4].HeaderText = "Dịa Chỉ";
            danhsachbacsi.Columns[4].Width = 175;
            danhsachbacsi.Columns[5].HeaderText = "CMND";
            danhsachbacsi.Columns[5].Width = 80;
            danhsachbacsi.Columns[6].HeaderText = "ĐT";
            danhsachbacsi.Columns[6].Width = 80;
            danhsachbacsi.Columns[7].HeaderText = "Khoa";
            danhsachbacsi.Columns[7].Width = 150;
            danhsachbacsi.Columns[8].HeaderText = "Ghi Chú";
            danhsachbacsi.Columns[8].Width = 150;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);
            xoatext();
            duocnhap(true);
            txtmabacsi.Focus();
            danhsachbacsi.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            txtmabacsi.Focus();
            danhsachbacsi.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setnut(true);
            danhsachbacsi.Enabled = true;
            duocnhap(false);
        }

        void kiemtra()
        {
            if (txtmabacsi.Text == "")
            {
                kiemtrathongtin.SetError(txtmabacsi, "Không được bỏ trống!");
            }
            if (txttenbacsi.Text == "")
            {
                kiemtrathongtin.SetError(txttenbacsi, "Không được bỏ trống!");
            }
            if (txtdiachi.Text == "")
            {
                kiemtrathongtin.SetError(txtdiachi, "Không được bỏ trống!");
            }
            if (txtsdt.Text == "")
            {
                kiemtrathongtin.SetError(txtsdt, "Không được bỏ trống!");
            }
            if (txtcmnd.Text == "")
            {
                kiemtrathongtin.SetError(txtcmnd, "Không được bỏ trống!");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them == 1)
            {
                //====================================== Thêm mới ====================================== 

                if (txtmabacsi.Text != "" && txttenbacsi.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "" && txtcmnd.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into BacSi Values ('" + txtmabacsi.Text + "', N'" + txttenbacsi.Text + "', N'" + comgioitinh.Text + "', '" + dtngaysinh.Text.ToString() + "', N'" + txtdiachi.Text + "', '" + txtcmnd.Text + "', '" + txtsdt.Text + "', N'" + comkhoa.SelectedValue.ToString() + "', N'" + txtghichu.Text + "')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công bác sĩ: " + txttenbacsi.Text.ToUpper());
                        loaddanhsachbacsi();
                        setnut(true);
                        danhsachbacsi.Enabled = true;
                        duocnhap(false);
                        kiemtrathongtin.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
                else
                {
                    kiemtra();
                    MessageBox.Show("Chưa đủ thông tin. Vui lòng kiểm tra lại");
                }
            }
            //====================================== Chỉnh sửa ====================================== 

            else
            {
                if (txtmabacsi.Text != "" && txttenbacsi.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "" && txtcmnd.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update BacSi Set MaBacSi ='" + txtmabacsi.Text + "', TenBacSi =N'" + txttenbacsi.Text + "', GioiTinhBacSi =N'" + comgioitinh.Text + "', NgaySinhBacSi ='" + dtngaysinh.Text.ToString() + "', DiaChiBacSi =N'" + txtdiachi.Text + "', CMNDBacSi ='" + txtcmnd.Text + "', SDTBacSi ='" + txtsdt.Text + "', MaKhoa= N'" + comkhoa.SelectedValue.ToString() + "', GhiChu =N'" + txtghichu.Text + "' Where MaBacSi ='" + this.danhsachbacsi.CurrentRow.Cells[0].Value.ToString() + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công bác sĩ: " + txttenbacsi.Text.ToUpper());
                        loaddanhsachbacsi();
                        setnut(true);
                        danhsachbacsi.Enabled = true;
                        duocnhap(false);
                        kiemtrathongtin.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                else
                {
                    kiemtra();
                    MessageBox.Show("Chưa đủ thông tin. Vui lòng kiểm tra lại");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa bác sĩ: " + txttenbacsi.Text.ToUpper() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete BacSi Where MaBacSi = '" + txtmabacsi.Text + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công bác sĩ: " + txttenbacsi.Text.ToUpper());
                    loaddanhsachbacsi();
                    setnut(true);
                    danhsachbacsi.Enabled = true;
                    duocnhap(false);
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void danhsachbacsi_SelectionChanged(object sender, EventArgs e)
        {
            txtmabacsi.Text = this.danhsachbacsi.CurrentRow.Cells[0].Value.ToString();
            txttenbacsi.Text = this.danhsachbacsi.CurrentRow.Cells[1].Value.ToString();
            comgioitinh.Text = this.danhsachbacsi.CurrentRow.Cells[2].Value.ToString();
            dtngaysinh.Text = this.danhsachbacsi.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = this.danhsachbacsi.CurrentRow.Cells[4].Value.ToString();
            txtcmnd.Text = this.danhsachbacsi.CurrentRow.Cells[5].Value.ToString();
            txtsdt.Text = this.danhsachbacsi.CurrentRow.Cells[6].Value.ToString();
            comkhoa.Text = this.danhsachbacsi.CurrentRow.Cells[7].Value.ToString();
            txtghichu.Text = this.danhsachbacsi.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
