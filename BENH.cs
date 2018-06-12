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
    public partial class BENH : Telerik.WinControls.UI.RadForm
    {
        public BENH()
        {
            InitializeComponent();
        }

        int them;

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BENH_Load(object sender, EventArgs e)
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
            txtmabenh.Clear();
            txttenbenh.Clear();
            txttrieuchung.Clear();
        }

        void duocnhap(bool val)
        {
            txtghichu.Enabled = val;
            txtmabenh.Enabled = val;
            txttenbenh.Enabled = val;
            txttrieuchung.Enabled = val;            
        }

        public void loaddanhsachbenh()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From Benh");
            danhsachbenh.DataSource = dt;
        }
        public void dinhdangdanhsach()
        {
            danhsachbenh.Columns[0].HeaderText = "Mã Bệnh";
            danhsachbenh.Columns[0].Width = 75;
            danhsachbenh.Columns[1].HeaderText = "Tên Bệnh";
            danhsachbenh.Columns[1].Width = 150;
            danhsachbenh.Columns[2].HeaderText = "Triệu Chứng";
            danhsachbenh.Columns[2].Width = 150;
            danhsachbenh.Columns[3].HeaderText = "Ghi Chú";
            danhsachbenh.Columns[3].Width = 150;
        }

        private void danhsachbenh_SelectionChanged(object sender, EventArgs e)
        {
            txtmabenh.Text = this.danhsachbenh.CurrentRow.Cells[0].Value.ToString();
            txttenbenh.Text = this.danhsachbenh.CurrentRow.Cells[1].Value.ToString();
            txttrieuchung.Text = this.danhsachbenh.CurrentRow.Cells[2].Value.ToString();
            txtghichu.Text = this.danhsachbenh.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);
            xoatext();
            duocnhap(true);
            txtmabenh.Focus();
            danhsachbenh.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            txtmabenh.Focus();
            danhsachbenh.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setnut(true);
            danhsachbenh.Enabled = true;
            duocnhap(false);            
        }

        void kiemtra()
        {
            if (txtmabenh.Text == "")
            {
                kiemtrathongtin.SetError(txtmabenh, "Chưa nhập mã bệnh!");
            }
            if (txttenbenh.Text == "")
            {
                kiemtrathongtin.SetError(txttenbenh, "Chưa nhập têns bệnh!");
            }
            if (txttrieuchung.Text == "")
            {
                kiemtrathongtin.SetError(txttrieuchung, "Chưa nhập triệu chứng bệnh!");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them == 1)
            {
                //====================================== Thêm mới ====================================== 

                if (txtmabenh.Text != "" && txttenbenh.Text != "" && txttrieuchung.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into Benh Values ('"+txtmabenh.Text+"', N'"+txttenbenh.Text+"', N'"+txttrieuchung.Text+"',N'"+txtghichu.Text+"')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công bệnh: " + txttenbenh.Text.ToUpper());
                        loaddanhsachbenh();
                        setnut(true);
                        danhsachbenh.Enabled = true;
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
                if (txtmabenh.Text != "" && txttenbenh.Text != "" && txttrieuchung.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update Benh Set MaBenh ='"+txtmabenh.Text+"', TenBenh =N'"+txttenbenh.Text+"', TrieuChung =N'"+txttrieuchung.Text+"', GhiChu =N'"+txtghichu.Text+"' Where MaBenh ='"+txtmabenh.Text+"'");
                    if (kq > 0)
                    {                        
                        MessageBox.Show("Cập nhật thành công bệnh: " + txttenbenh.Text.ToUpper());
                        loaddanhsachbenh();
                        setnut(true);
                        danhsachbenh.Enabled = true;
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
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa bệnh: " + txttenbenh.Text.ToUpper() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete Benh Where MaBenh = '"+txtmabenh.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công bệnh: " + txtmabenh.Text.ToUpper());
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
    }
}
