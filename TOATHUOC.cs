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
    public partial class TOATHUOC : Telerik.WinControls.UI.RadForm
    {
        public TOATHUOC()
        {
            InitializeComponent();
        }

        int them;

        public class chitiettoathuoc
        {
            public static string matoathuoc;
            public static string makhambenh;
        }
        private void TOATHUOC_Load(object sender, EventArgs e)
        {
            loadmakhambenh();
            loaddanhsachtoathuoc();
            dinhdangdanhsach();
            kiemtraquyen();
        }
        
        public void kiemtraquyen()
        {
            if (DangNhap.bientoancuc.maquyen == "TT" || DangNhap.bientoancuc.maquyen == "BS")
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

        void xoatext()
        {
            //txtnatoa.Clear();

        }

        void duocnhap(bool val)
        {
            commakhambenh.Enabled = val;
            dtngaylap.Enabled = val;
            txtnatoa.Enabled = val;
        }


        public void loadmakhambenh()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhieuKhamBenh From PhieuKhamBenh");
            commakhambenh.DataSource = dt;
            commakhambenh.DisplayMember = "MaPhieuKhamBenh";
            commakhambenh.ValueMember = "MaPhieuKhamBenh";
            commakhambenh.Columns[0].HeaderText = "Mã KHÁM BỆNH";
            commakhambenh.Columns[0].Width = 240;       
        }

        public void loaddanhsachtoathuoc()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * From ToaThuoc");
            danhsachtoathuoc.DataSource = dt;
        }

        public void dinhdangdanhsach()
        {
            danhsachtoathuoc.Columns[0].HeaderText = "MaToaThoc";
            danhsachtoathuoc.Columns[0].Width = 165;
            danhsachtoathuoc.Columns[1].HeaderText = "NgayLap";
            danhsachtoathuoc.Columns[1].Width = 300;
            danhsachtoathuoc.Columns[2].HeaderText = "MaPhieuKhamBenh";
            danhsachtoathuoc.Columns[2].Width = 280;
        }

        private void danhsachtoathuoc_SelectionChanged(object sender, EventArgs e)
        {
            txtnatoa.Text = this.danhsachtoathuoc.CurrentRow.Cells[0].Value.ToString();
            commakhambenh.Text = this.danhsachtoathuoc.CurrentRow.Cells[2].Value.ToString();
            dtngaylap.Text = this.danhsachtoathuoc.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = 1;
            setnut(false);
            xoatext();
            duocnhap(true);
            txtnatoa.Focus();
            danhsachtoathuoc.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            them = 2;
            setnut(false);
            duocnhap(true);
            txtnatoa.Focus();
            danhsachtoathuoc.Enabled = false;
            //mabenh = combenh.SelectedValue.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete ToaThuoc Where MaToaThuoc ='"+txtnatoa.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loaddanhsachtoathuoc();
                    setnut(true);
                    danhsachtoathuoc.Enabled = true;
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

                if (txtnatoa.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Insert Into ToaThuoc Values ('"+txtnatoa.Text+"', '"+dtngaylap.Text.ToString()+"', '"+commakhambenh.SelectedValue.ToString()+"')");
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loaddanhsachtoathuoc();
                        setnut(true);
                        danhsachtoathuoc.Enabled = true;
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
                if (txtnatoa.Text != "")
                {
                    KetNoi z = new KetNoi();
                    int kq = z.xulydulieu("Update ToaThuoc Set MaToaThuoc ='"+txtnatoa.Text+"', NgayLapToaThuoc ='"+dtngaylap.Text.ToString()+"', MaPhieuKhamBenh ='"+commakhambenh.SelectedValue.ToString()+"' Where MaToaThuoc ='" + this.danhsachtoathuoc.CurrentRow.Cells[0].Value.ToString() +"'");
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        loaddanhsachtoathuoc();
                        setnut(true);
                        danhsachtoathuoc.Enabled = true;
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
            danhsachtoathuoc.Enabled = true;
            duocnhap(false);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhsachtoathuoc_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            chitiettoathuoc.matoathuoc = this.danhsachtoathuoc.CurrentRow.Cells[0].Value.ToString();
            chitiettoathuoc.makhambenh = this.danhsachtoathuoc.CurrentRow.Cells[2].Value.ToString();
            CHITIETTOATHUOC cttt = new CHITIETTOATHUOC();
            cttt.Show();
        }
    }
}
