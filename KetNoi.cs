using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QLKhamChuaBenh
{
    class KetNoi
    {

        public SqlConnection kn = new SqlConnection();
        public void kn_csdl()
        {
            string chuoikn = "Data Source=NTQT;Initial Catalog=QL_BENH;Integrated Security=True";
            kn.ConnectionString = chuoikn;
            kn.Open();
        }

        public void dongketnoi()
        {
            if (kn.State == ConnectionState.Open)
            {
                kn.Close();
            }
        }

        public DataTable bangdulieu = new DataTable();

        public DataTable laybang(string caulenh)
        {
            try
            {
                kn_csdl();
                SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, kn);
                DataSet ds = new DataSet();

                Adapter.Fill(bangdulieu);
            }
            catch (System.Exception)
            {
                bangdulieu = null;
            }
            finally
            {
                dongketnoi();
            }

            return bangdulieu;
        }

        public int xulydulieu(string caulenhsql)
        {
            int kq = 0;
            try
            {
                kn_csdl();
                SqlCommand lenh = new SqlCommand(caulenhsql, kn);
                kq = lenh.ExecuteNonQuery();
            }

            catch
            {
            }

            finally
            {
                dongketnoi();
            }
            return kq;
        }
    }
}
