using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyNhaHang
{
    public partial class ThongKe : Form
    {
        SqlConnection connect = new SqlConnection(Login.connectionString);
        string date1 = "";
        string date2 = "";
        public ThongKe()
        {
            InitializeComponent();
            load(date1, date2);
        }
        private void load(string d1, string d2)
        {
            string query = "";
            string queryTotal = "";
            string querySumMoney = "";
            if(d1.Trim().Length > 0 && d2.Trim().Length > 0)
            {
                query = "SELECT datBan.maMonAn as 'Mã món', monAn.tenMonAn as 'Tên món ăn', maBanAn as 'Mã Bàn Ăn', tenKhachHang as 'Tên khách hàng',thoiGianDat as 'Thời gian', soLuongMonAn as 'Số lượng', donVi as 'Đơn vị', giaBan as 'Giá bán (cho mỗi đơn vị)' FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn WHERE datBan.thoiGianDat >= '" + date1 + "' AND datBan.thoiGianDat <= '" + date2 + "'";
                queryTotal = "SELECT COUNT(maDat) as c FROM datBan WHERE thoiGianDat >= '"+d1+"' AND thoiGianDat <= '"+d2+"'";
                querySumMoney = "SELECT soLuongMonAn as a, giaBan as g FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn WHERE datBan.thoiGianDat >= '"+d1+"' AND thoiGianDat <= '"+d2+"'";
            }
            else if (d1.Trim().Length > 0 && d2.Trim().Length == 0)
            {
                query = "SELECT datBan.maMonAn as 'Mã món',monAn.tenMonAn as 'Tên món ăn', maBanAn as 'Mã Bàn Ăn', tenKhachHang as 'Tên khách hàng',thoiGianDat as 'Thời gian', soLuongMonAn as 'Số lượng', donVi as 'Đơn vị', giaBan as 'Giá bán (cho mỗi đơn vị)' FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn WHERE datBan.thoiGianDat >= '" + date1 + "'";
                queryTotal = "SELECT COUNT(maDat) as c FROM datBan WHERE thoiGianDat >= '" + d1 + "'";
                querySumMoney = "SELECT soLuongMonAn as a, giaBan as g FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn WHERE datBan.thoiGianDat >= '" + d1 + "'";
            }
            else if(d1.Trim().Length == 0 && d2.Trim().Length > 0)
            {
                query = "SELECT datBan.maMonAn as 'Mã món',monAn.tenMonAn as 'Tên món ăn', maBanAn as 'Mã Bàn Ăn', tenKhachHang as 'Tên khách hàng',thoiGianDat as 'Thời gian', soLuongMonAn as 'Số lượng', donVi as 'Đơn vị', giaBan as 'Giá bán (cho mỗi đơn vị)' FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn WHERE datBan.thoiGianDat <= '" + date2 + "'";
                queryTotal = "SELECT COUNT(maDat) as c FROM datBan WHERE thoiGianDat <= '" + d2 + "'";
                querySumMoney = "SELECT soLuongMonAn as a, giaBan as g FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn WHERE thoiGianDat <= '" + d2 + "'";
            }
            else
            {
                query = "SELECT datBan.maMonAn as 'Mã món',monAn.tenMonAn as 'Tên món ăn', maBanAn as 'Mã Bàn Ăn', tenKhachHang as 'Tên khách hàng',thoiGianDat as 'Thời gian', soLuongMonAn as 'Số lượng', donVi as 'Đơn vị', giaBan as 'Giá bán (cho mỗi đơn vị)' FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn";
                queryTotal = "SELECT COUNT(maDat) as c FROM datBan";
                querySumMoney = "SELECT soLuongMonAn as a, giaBan as g FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn";
            }
            SqlDataAdapter ad = new SqlDataAdapter(query, connect);
            var t = new DataTable();
            ad.Fill(t);
            dataGridView1.DataSource = t;

            SqlDataAdapter adap1 = new SqlDataAdapter(queryTotal, connect);
            var t1 = new DataTable();
            adap1.Fill(t1);
            label6.Text = t1.Rows[0]["c"].ToString();

            SqlDataAdapter adap2 = new SqlDataAdapter(querySumMoney, connect);
            int total = 0;
            var t2 = new DataTable();
            adap2.Fill(t2);
            for(int i = 0; i< t2.Rows.Count; i++)
            {
                total += Convert.ToInt32(t2.Rows[i]["a"]) * Convert.ToInt32(t2.Rows[i]["g"]);
            }
            label8.Text = total.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.ShowDialog();
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            load(date1, date2);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date2 = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            load(date1, date2);
        }

        
    }
}
