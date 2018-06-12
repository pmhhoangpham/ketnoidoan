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
    public partial class Thuoc : Telerik.WinControls.UI.RadForm
    {
        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            loaddanhsachthuoc();
            dinhdangdanhsach();
        }

        public void loaddanhsachthuoc()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select t.MaThuoc, t.TenThuoc, t.TacDungChinh, t.TacDungPhu, t.DonGia, t.CachSuDung, t.SoLuongTon, ncc.TenNhaCungCap From Thuoc t, NhaCungCap ncc Where t.MaNhaCungCap = ncc.MaNhaCungCap");
            danhsachthuoc.DataSource = dt;
        }
        public void dinhdangdanhsach()
        {
            danhsachthuoc.Columns[0].HeaderText = "Mã";
            danhsachthuoc.Columns[0].Width = 80;
            danhsachthuoc.Columns[1].HeaderText = "Tên Thuốc";
            danhsachthuoc.Columns[1].Width = 250;
            danhsachthuoc.Columns[2].HeaderText = "Tác Dụng Chính";
            danhsachthuoc.Columns[2].Width = 140;
            danhsachthuoc.Columns[3].HeaderText = "Tác Dụng Phụ";
            danhsachthuoc.Columns[3].Width = 140;
            danhsachthuoc.Columns[4].HeaderText = "Đơn Giá";
            danhsachthuoc.Columns[4].Width = 80;
            danhsachthuoc.Columns[5].HeaderText = "Cách Sử Dụng";
            danhsachthuoc.Columns[5].Width = 180;
            danhsachthuoc.Columns[6].HeaderText = "SL";
            danhsachthuoc.Columns[6].Width = 50;
            danhsachthuoc.Columns[7].HeaderText = "Nhà Cung Cấp";
            danhsachthuoc.Columns[7].Width = 195;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xóa thuốc: " + this.danhsachthuoc.CurrentRow.Cells[0].Value.ToString() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Delete Thuoc Where MaThuoc = '" + this.danhsachthuoc.CurrentRow.Cells[0].Value.ToString() + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công thuốc: " + this.danhsachthuoc.CurrentRow.Cells[0].Value.ToString());
                    loaddanhsachthuoc();                    
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }
    }
}
