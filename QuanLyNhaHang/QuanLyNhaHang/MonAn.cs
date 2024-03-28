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
    public partial class MonAn : Form
    {
        SqlConnection connect = new SqlConnection(Login.connectionString);
        public MonAn()
        {
            InitializeComponent();
            load("SELECT maMonAn as 'Mã món ăn', tenMonAn as 'Tên món ăn', giaBan as 'Giá bán', donVi as 'Đơn vị bán' FROM monAn");
        }
        private void load(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, connect);
            var t = new DataTable();
            adap.Fill(t);
            dataGridView1.DataSource = t;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.ShowDialog();
            Close();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Hide();
            ThemMonAn t = new ThemMonAn();
            t.ShowDialog();
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            load("SELECT maMonAn as 'Mã món ăn', tenMonAn as 'Tên món ăn', giaBan as 'Giá bán', donVi as 'Đơn vị bán' FROM monAn WHERE tenMonAn LIKE N'%" + search + "%'");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect.Open();
            string id = textBox1.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM monAn WHERE maMonAn = " + id + "", connect);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                connect.Close();
                connect.Open();
                SqlCommand cmd2 = new SqlCommand("DELETE FROM monAn WHERE maMonAn = " + id + "", connect);
                DialogResult d = MessageBox.Show("Nếu xóa món này, bạn sẽ xóa hết tất cả danh sách đặt bàn liên quan", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (d == DialogResult.OK)
                {
                    SqlCommand cmd3 = new SqlCommand("DELETE FROM datBan WHERE maMonAn = " + id + "", connect);
                    cmd3.ExecuteNonQuery();
                    if (cmd2.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        load("SELECT maMonAn as 'Mã món ăn', tenMonAn as 'Tên món ăn', giaBan as 'Giá bán', donVi as 'Đơn vị bán' FROM monAn");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra", "Xóa thất bại");
                    }
                }
                connect.Close();
            }
            else
            {
                MessageBox.Show("id Không tồn tại");
            }
        }

        
    }
}
