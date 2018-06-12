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
    public partial class NHACCUNGCAP : Telerik.WinControls.UI.RadForm
    {
        public NHACCUNGCAP()
        {
            InitializeComponent();
        }

        int them;
        private void NHACCUNGCAP_Load(object sender, EventArgs e)
        {
            setnut(true);
            duocnhap(false);
            loaddanhsaachnhacungcap();
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
            txttennhacungcap.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtnguoidaidien.Clear();

        }

        void duocnhap(bool val)
        {           
            txtmanhaccungcap.Enabled = val;
            txttennhacungcap.Enabled = val;
            txtsdt.Enabled = val;
            txtdiachi.Enabled = val;
            txtnguoidaidien.Enabled = val;         
        }

        public void loaddanhsaachnhacungcap()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From NhaCungCap");
            danhsachnhacungcap.DataSource = dt;
        }
        public void dinhdangdanhsach()
        {
            danhsachnhacungcap.Columns[0].HeaderText = "Mã";
            danhsachnhacungcap.Columns[0].Width = 75;
            danhsachnhacungcap.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            danhsachnhacungcap.Columns[1].Width = 180;
            danhsachnhacungcap.Columns[2].HeaderText = "SĐT";
            danhsachnhacungcap.Columns[2].Width = 80;
            danhsachnhacungcap.Columns[3].HeaderText = "Địa Chỉ";
            danhsachnhacungcap.Columns[3].Width = 175;
            danhsachnhacungcap.Columns[4].HeaderText = "Người Địa Diện";
            danhsachnhacungcap.Columns[4].Width = 175;          
        }

        private void danhsachnhacungcap_SelectionChanged(object sender, EventArgs e)
        {
            txtmanhaccungcap.Text = this.danhsachnhacungcap.CurrentRow.Cells[0].Value.ToString();
            txttennhacungcap.Text = this.danhsachnhacungcap.CurrentRow.Cells[1].Value.ToString();
            txtsdt.Text = this.danhsachnhacungcap.CurrentRow.Cells[2].Value.ToString();
            txtdiachi.Text = this.danhsachnhacungcap.CurrentRow.Cells[3].Value.ToString();
            txtnguoidaidien.Text = this.danhsachnhacungcap.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);
            xoatext();
            duocnhap(true);
            txtmanhaccungcap.Focus();
            danhsachnhacungcap.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            them = 2;
            setnut(false);
            duocnhap(true);
            txtmanhaccungcap.Focus();
            danhsachnhacungcap.Enabled = false;
        }

        void kiemtra()
        {
            if (txtmanhaccungcap.Text == "")
            {
                kiemtrathongtin.SetError(txtmanhaccungcap, "Không được bỏ trống!");
            }
            if (txttennhacungcap.Text == "")
            {
                kiemtrathongtin.SetError(txttennhacungcap, "Không được bỏ trống!");
            }
            if (txtdiachi.Text == "")
            {
                kiemtrathongtin.SetError(txtdiachi, "Không được bỏ trống!");
            }
            if (txtsdt.Text == "")
            {
                kiemtrathongtin.SetError(txtsdt, "Không được bỏ trống!");
            }
            if (txtnguoidaidien.Text == "")
            {
                kiemtrathongtin.SetError(txtnguoidaidien, "Không được bỏ trống!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa nhà cung cấp: " + txttennhacungcap.Text.ToUpper() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete NhaCungCap Where MaNhaCungCap = '"+txtmanhaccungcap.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công nhà cung cấp: " + txttennhacungcap.Text.ToUpper());
                    loaddanhsaachnhacungcap();
                    setnut(true);
                    danhsachnhacungcap.Enabled = true;
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

                if (txtmanhaccungcap.Text != "" && txttennhacungcap.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "" && txtnguoidaidien.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into NhaCungCap Values ('"+txtmanhaccungcap.Text+"', N'"+txttennhacungcap.Text+"', '"+txtsdt.Text+"', N'"+txtdiachi.Text+"', N'"+txtnguoidaidien.Text+"')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công nhà cung cấp: " + txttennhacungcap.Text.ToUpper());
                        loaddanhsaachnhacungcap();
                        setnut(true);
                        danhsachnhacungcap.Enabled = true;
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
                if (txtmanhaccungcap.Text != "" && txttennhacungcap.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "" && txtnguoidaidien.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update NhaCungCap Set MaNhaCungCap ='"+txtmanhaccungcap.Text+"', TenNhaCungCap =N'"+txttennhacungcap.Text+"', SDTNhaCungCap ='"+txtsdt.Text+"', DiaChiNhaCungCap= N'"+txtdiachi.Text+"', NguoiDaiDien =N'"+txtnguoidaidien.Text+"' Where MaNhaCungCap ='"+ this.danhsachnhacungcap.CurrentRow.Cells[0].Value.ToString() + "'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công nhà cung cấp: " + txttennhacungcap.Text.ToUpper());
                        loaddanhsaachnhacungcap();
                        setnut(true);
                        danhsachnhacungcap.Enabled = true;
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setnut(true);
            danhsachnhacungcap.Enabled = true;
            duocnhap(false);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
