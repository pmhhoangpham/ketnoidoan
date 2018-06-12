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
    public partial class BENHNHAN : Telerik.WinControls.UI.RadForm
    {
        public BENHNHAN()
        {
            InitializeComponent();
        }

        int them;
        private void BENHNHAN_Load(object sender, EventArgs e)
        {
            setnut(true);
            duocnhap(false);
            loaddanhsachbenh();
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
            txttenbenhnhan.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            txtcmnd.Clear();

        }

        void duocnhap(bool val)
        {
            txtghichu.Enabled = val;
            txtmabenhnhan.Enabled = val;
            txttenbenhnhan.Enabled = val;
            txtdiachi.Enabled = val;
            txtsdt.Enabled = val;
            txtcmnd.Enabled = val;
            comgioitinh.Enabled = val;
            dtngaysinh.Enabled = val;
        }

        public void loaddanhsachbenh()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From HoSoBenhNhan");
            danhsachbenhnhan.DataSource = dt;
        }
        public void dinhdangdanhsach()
        {
            danhsachbenhnhan.Columns[0].HeaderText = "Mã";
            danhsachbenhnhan.Columns[0].Width = 75;
            danhsachbenhnhan.Columns[1].HeaderText = "Tên Bệnh Nhân";
            danhsachbenhnhan.Columns[1].Width = 180;
            danhsachbenhnhan.Columns[2].HeaderText = "Giới Tính";
            danhsachbenhnhan.Columns[2].Width = 80;
            danhsachbenhnhan.Columns[3].HeaderText = "Ngay Sinh";
            danhsachbenhnhan.Columns[3].Width = 80;
            danhsachbenhnhan.Columns[4].HeaderText = "Dịa Chỉ";
            danhsachbenhnhan.Columns[4].Width = 175;
            danhsachbenhnhan.Columns[5].HeaderText = "SĐT";
            danhsachbenhnhan.Columns[5].Width = 80;
            danhsachbenhnhan.Columns[6].HeaderText = "CMND";
            danhsachbenhnhan.Columns[6].Width = 80;
            danhsachbenhnhan.Columns[7].HeaderText = "Ghi Chú";
            danhsachbenhnhan.Columns[7].Width = 150;
        }

        private void danhsachbenhnhan_SelectionChanged(object sender, EventArgs e)
        {
            txtmabenhnhan.Text = this.danhsachbenhnhan.CurrentRow.Cells[0].Value.ToString();
            txttenbenhnhan.Text = this.danhsachbenhnhan.CurrentRow.Cells[1].Value.ToString();
            comgioitinh.Text = this.danhsachbenhnhan.CurrentRow.Cells[2].Value.ToString();
            dtngaysinh.Text = this.danhsachbenhnhan.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = this.danhsachbenhnhan.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = this.danhsachbenhnhan.CurrentRow.Cells[5].Value.ToString();
            txtcmnd.Text = this.danhsachbenhnhan.CurrentRow.Cells[6].Value.ToString();
            txtghichu.Text = this.danhsachbenhnhan.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);
            xoatext();
            duocnhap(true);
            txtmabenhnhan.Focus();
            danhsachbenhnhan.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            txtmabenhnhan.Focus();
            danhsachbenhnhan.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setnut(true);
            danhsachbenhnhan.Enabled = true;
            duocnhap(false);
        }

        void kiemtra()
        {
            if (txtmabenhnhan.Text == "")
            {
                kiemtrathongtin.SetError(txtmabenhnhan, "Không được bỏ trống!");
            }
            if (txttenbenhnhan.Text == "")
            {
                kiemtrathongtin.SetError(txttenbenhnhan, "Không được bỏ trống!");
            }
            if (txtdiachi.Text == "")
            {
                kiemtrathongtin.SetError(txtdiachi, "Không được bỏ trống!");
            }
            if (txtsdt.Text == "")
            {
                kiemtrathongtin.SetError(txtsdt, "Không được bỏ trống!");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them == 1)
            {
                //====================================== Thêm mới ====================================== 

                if (txtmabenhnhan.Text != "" && txttenbenhnhan.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into HoSoBenhNhan Values ('" + txtmabenhnhan.Text + "', N'" + txttenbenhnhan.Text + "', N'" + comgioitinh.Text + "', '" + dtngaysinh.Text.ToString() + "', N'" + txtdiachi.Text + "', '" + txtsdt.Text + "', '" + txtcmnd.Text + "', N'" + txtghichu.Text + "')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công bệnh nhân: " + txttenbenhnhan.Text.ToUpper());
                        loaddanhsachbenh();
                        setnut(true);
                        danhsachbenhnhan.Enabled = true;
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
                if (txtmabenhnhan.Text != "" && txttenbenhnhan.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update HoSoBenhNhan Set MaBenhNhan ='" + txtmabenhnhan.Text + "', TenBenhNhan =N'" + txttenbenhnhan.Text + "', GioiTinhBenhNhan =N'" + comgioitinh.Text + "', NgaySinhBenhNhan ='" + dtngaysinh.Text.ToString() + "', DiaChiBenhNhan =N'" + txtdiachi.Text + "' , SDTBenhNhan ='" + txtsdt.Text + "', CMNDBenhNhan ='" + txtcmnd.Text + "', GhiChu =N'" + txtghichu.Text + "' Where MaBenhNhan ='" + this.danhsachbenhnhan.CurrentRow.Cells[0].Value.ToString() + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công bệnh nhân: " + txttenbenhnhan.Text.ToUpper());
                        loaddanhsachbenh();
                        setnut(true);
                        danhsachbenhnhan.Enabled = true;
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
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa bệnh nhân: " + txttenbenhnhan.Text.ToUpper() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete HoSoBenhNhan Where MaBenhNhan = '" + txtmabenhnhan.Text + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công bệnh: " + txttenbenhnhan.Text.ToUpper());
                    loaddanhsachbenh();
                    setnut(true);
                    danhsachbenhnhan.Enabled = true;
                    duocnhap(false);
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
