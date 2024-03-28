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
    public partial class Main : Form
    {
        SqlConnection connect = new SqlConnection(Login.connectionString);
        public Main()
        {
            InitializeComponent();
            load("SELECT datBan.maMonAn as 'Mã món',monAn.tenMonAn as 'Tên món ăn', banAn.maBanAn as 'Mã Bàn Ăn', tenKhachHang as 'Tên khách hàng', thoiGianDat as 'Thời gian', soLuongMonAn as 'Số lượng', donVi as 'Đơn vị', giaBan as 'Giá bán (cho mỗi đơn vị)' FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn INNER JOIN banAn ON banAn.maBanAn = datBan.maBanAn WHERE banAn.conTrong = 0");
            cbbQLCH.Items.Add("Bàn đang sử dụng");
            cbbQLCH.Items.Add("Bàn trống");
            cbbQLCH.Items.Add("Tất cả");
            cbbQLCH.Items.Add("Thêm");
        }
        private void load(string query)
        {
            SqlDataAdapter ad = new SqlDataAdapter(query, connect);
            var t = new DataTable();
            ad.Fill(t);
            dataGridView1.DataSource = t;
        }

        private void btnQLB_Click(object sender, EventArgs e)
        {
            Hide();
            BanAn b = new BanAn();
            b.ShowDialog();
            Close();
        }

        private void btnQLMA_Click(object sender, EventArgs e)
        {
            Hide();
            MonAn m = new MonAn();
            m.ShowDialog();
            Close();
        }

        private void cbbQLCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbQLCH.SelectedIndex.ToString() == "0")
            {
                load("SELECT datBan.maMonAn as 'Mã món',monAn.tenMonAn as 'Tên món ăn', banAn.maBanAn as 'Mã Bàn Ăn', tenKhachHang as 'Tên khách hàng', thoiGianDat as 'Thời gian', soLuongMonAn as 'Số lượng', donVi as 'Đơn vị', giaBan as 'Giá bán (cho mỗi đơn vị)' FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn INNER JOIN banAn ON banAn.maBanAn = datBan.maBanAn WHERE banAn.conTrong = 0");
            }
            else if(cbbQLCH.SelectedIndex.ToString() == "1")
            {
                load("SELECT datBan.maMonAn as 'Mã món',monAn.tenMonAn as 'Tên món ăn', banAn.maBanAn as 'Mã Bàn Ăn', tenKhachHang as 'Tên khách hàng', thoiGianDat as 'Thời gian', soLuongMonAn as 'Số lượng', donVi as 'Đơn vị', giaBan as 'Giá bán (cho mỗi đơn vị)' FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn INNER JOIN banAn ON banAn.maBanAn = datBan.maBanAn WHERE banAn.conTrong = 1");
            }
            else
            {
                load("SELECT datBan.maMonAn as 'Mã món', monAn.tenMonAn as 'Tên món ăn', banAn.maBanAn as 'Mã Bàn Ăn', tenKhachHang as 'Tên khách hàng', thoiGianDat as 'Thời gian', soLuongMonAn as 'Số lượng', donVi as 'Đơn vị', giaBan as 'Giá bán (cho mỗi đơn vị)' FROM datBan INNER JOIN monAn ON datBan.maMonAn = monAn.maMonAn INNER JOIN banAn ON banAn.maBanAn = datBan.maBanAn");
            }
        }

        private void btnQLDB_Click(object sender, EventArgs e)
        {
            Hide();
            DatBan d = new DatBan();
            d.ShowDialog();
            Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Hide();
            ThongKe t = new ThongKe();
            t.ShowDialog();
            Close();
        }
    }
}
