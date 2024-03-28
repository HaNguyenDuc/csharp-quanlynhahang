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
    public partial class ThemMonAn : Form
    {
        SqlConnection connect = new SqlConnection(Login.connectionString);
        public ThemMonAn()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            connect.Open();
            string name = textBox1.Text;
            string price = numericUpDown1.Value.ToString();
            string unit = textBox2.Text;
            SqlCommand cmd = new SqlCommand("INSERT INTO monAn(tenMonAn, giaBan, donVi) VALUES (N'" + name + "', " + price + ", N'" + unit + "')", connect);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                Hide();
                MonAn m = new MonAn();
                m.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Thất bại", "Có lỗi xảy ra");
            }
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            MonAn mon = new MonAn();
            mon.ShowDialog();
            Close();
        }

       
    }
}
