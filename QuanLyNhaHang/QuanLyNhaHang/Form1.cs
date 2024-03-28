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
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-MJA6T2QL;Initial Catalog=QLNH;Integrated Security=True");
        public static string connectionString = @"Data Source=LAPTOP-MJA6T2QL;Initial Catalog=QLNH;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usn = textBox1.Text;
            string password = textBox2.Text;
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dangNhap WHERE tenDangNhap = '"+usn+"'AND matKhau = '"+password+"'", connect);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Đăng nhập thành công");
                Hide();
                Main m = new Main();
                m.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thất bại", MessageBoxButtons.RetryCancel);
            }
            connect.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
