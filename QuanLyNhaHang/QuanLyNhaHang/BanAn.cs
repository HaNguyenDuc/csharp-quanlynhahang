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
    public partial class BanAn : Form
    {
        SqlConnection connect = new SqlConnection(Login.connectionString);
        public BanAn()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            SqlDataAdapter adap = new SqlDataAdapter("select maBanAn as 'Mã Bàn', conTrong as 'Trống (1-> trống, 0 -> bận)' from banAn", connect);
            var d = new DataTable();
            adap.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void btnThemBanAn_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO banAn (conTrong) values (1)", connect);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm mới bàn thành công");
                load();
            }
            else
            {
                MessageBox.Show("Thất bại", "Có lỗi xảy ra");
            }
            connect.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect.Open();
            string id = textBox1.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM banAn WHERE maBanAn = " + id + "", connect);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                connect.Close();
                connect.Open();
                SqlCommand cmd2 = new SqlCommand("DELETE FROM banAn WHERE maBanAn = " + id + "", connect);
                DialogResult d = MessageBox.Show("Nếu xóa bàn này, bạn sẽ xóa hết tất cả danh sách đặt bàn liên quan", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (d == DialogResult.OK)
                {
                    SqlCommand cmd3 = new SqlCommand("DELETE FROM datBan WHERE maBanAn = " + id + "", connect);
                    cmd3.ExecuteNonQuery();
                    if (cmd2.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        load();
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

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.ShowDialog();
            Close();
        }

        private void btnTraban_Click(object sender, EventArgs e)
        {
            connect.Open();
            string id = textBox1.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM banAn WHERE maBanAn = " + id + "", connect);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                connect.Close();
                connect.Open();
                DialogResult d = MessageBox.Show("Hãy chắc chắn bàn đã trống trước khi trả bàn", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (d == DialogResult.OK)
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE banAn SET conTrong = 1 WHERE maBanAn = " + id + "", connect);
                    if (cmd3.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Trả bàn thành công");
                        load();
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
