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
    public partial class XETNGHIEM : Telerik.WinControls.UI.RadForm
    {
        public XETNGHIEM()
        {
            InitializeComponent();
        }

        int them;
        private void XETNGHIEM_Load(object sender, EventArgs e)
        {
            setnut(true);
            duocnhap(false);
            loaddanhsachxetnghiem();
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
            txttenxetnghiem.Clear();
            txtdongia.Clear();
        }

        void duocnhap(bool val)
        {
            txtghichu.Enabled = val;
            txtmaxetnghiem.Enabled = val;
            txttenxetnghiem.Enabled = val;
            txtdongia.Enabled = val;
        }

        public void loaddanhsachxetnghiem()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From XetNghiem");
            danhsachxetnghiem.DataSource = dt;
        }
        public void dinhdangdanhsach()
        {
            danhsachxetnghiem.Columns[0].HeaderText = "Mã XN";
            danhsachxetnghiem.Columns[0].Width = 75;
            danhsachxetnghiem.Columns[1].HeaderText = "Tên XN";
            danhsachxetnghiem.Columns[1].Width = 150;
            danhsachxetnghiem.Columns[2].HeaderText = "Đơn Giá";
            danhsachxetnghiem.Columns[2].Width = 150;
            danhsachxetnghiem.Columns[3].HeaderText = "Ghi Chú";
            danhsachxetnghiem.Columns[3].Width = 150;
        }

        private void danhsachxetnghiem_SelectionChanged(object sender, EventArgs e)
        {
            txtmaxetnghiem.Text = this.danhsachxetnghiem.CurrentRow.Cells[0].Value.ToString();
            txttenxetnghiem.Text = this.danhsachxetnghiem.CurrentRow.Cells[1].Value.ToString();
            txtdongia.Text = this.danhsachxetnghiem.CurrentRow.Cells[2].Value.ToString();
            txtghichu.Text = this.danhsachxetnghiem.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);
            xoatext();
            duocnhap(true);
            txtmaxetnghiem.Focus();
            danhsachxetnghiem.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            txtmaxetnghiem.Focus();
            danhsachxetnghiem.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setnut(true);
            danhsachxetnghiem.Enabled = true;
            duocnhap(false);
        }

        void kiemtra()
        {
            if (txtmaxetnghiem.Text == "")
            {
                kiemtrathongtin.SetError(txtmaxetnghiem, "Chưa nhập mã xét nghiệm!");
            }
            if (txttenxetnghiem.Text == "")
            {
                kiemtrathongtin.SetError(txttenxetnghiem, "Chưa nhập tên nghiệm!");
            }
            if (txtdongia.Text == "")
            {
                kiemtrathongtin.SetError(txtdongia, "Chưa nhập đơn giá xét nghiệm!");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (them == 1)
            {
                //====================================== Thêm mới ====================================== 

                if (txtmaxetnghiem.Text != "" && txttenxetnghiem.Text != "" && txtdongia.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into XetNghiem Values ('"+txtmaxetnghiem.Text+"', N'"+txttenxetnghiem.Text+"', '"+txtdongia.Text+"', N'"+txtghichu.Text+"')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công xét nghiệm: " + txttenxetnghiem.Text.ToUpper());
                        loaddanhsachxetnghiem();
                        setnut(true);
                        danhsachxetnghiem.Enabled = true;
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
                if (txtmaxetnghiem.Text != "" && txttenxetnghiem.Text != "" && txtdongia.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update XetNghiem Set MaXetNghiem ='"+txtmaxetnghiem.Text+"', TenXetNghiem =N'"+txttenxetnghiem.Text+"', DonGia ='"+txtdongia.Text+"', GhiChu =N'"+txtghichu.Text+"' Where MaXetNghiem ='"+txtmaxetnghiem.Text+"'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công xét nghiệm: " + txttenxetnghiem.Text.ToUpper());
                        loaddanhsachxetnghiem();
                        setnut(true);
                        danhsachxetnghiem.Enabled = true;
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
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa xét nghiệm: " + txttenxetnghiem.Text.ToUpper() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete XetNghiem Where MaXetNghiem ='"+txtmaxetnghiem.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công bệnh: " + txttenxetnghiem.Text.ToUpper());
                    loaddanhsachxetnghiem();
                    setnut(true);
                    danhsachxetnghiem.Enabled = true;
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
