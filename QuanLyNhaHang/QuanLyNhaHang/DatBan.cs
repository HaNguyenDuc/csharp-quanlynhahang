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
    public partial class DatBan : Form
    {
        SqlConnection connect = new SqlConnection(Login.connectionString);
        public DatBan()
        {
            InitializeComponent();
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT tenMonAn as t, maMonAn as m FROM monAn", connect);
            var t1 = new DataTable();
            adapter1.Fill(t1);
            comboBox2.DataSource = t1;
            comboBox2.DisplayMember = "t";
            comboBox2.ValueMember = "m";

            SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT maBanAn as m from banAn", connect);
            DataTable t2 = new DataTable();
            adapter2.Fill(t2);
            comboBox1.DataSource = t2;
            comboBox1.DisplayMember = "m";
            comboBox1.ValueMember = "m";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.ShowDialog();
            Close();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            connect.Open();
            string maBan = comboBox1.SelectedValue.ToString();
            string maMon = comboBox2.SelectedValue.ToString();
            int soLuong = Convert.ToInt32(numericUpDown1.Value);
            string tenKhach = textBox1.Text;
            string thoiGian = dateTimePicker1.Value.ToString("MM/dd/yyyy hh:mm:ss");
            SqlCommand cmd = new SqlCommand("insert into datBan (maMonAn, maBanAn, tenKhachHang, soLuongMonAn, thoiGianDat) VALUES (" + maMon + "," + maBan + ",	N'" + tenKhach + "', " + soLuong + ", '" + thoiGian + "')", connect);
            if (cmd.ExecuteNonQuery() > 0)
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE banAn set conTrong = 0 WHERE maBanAn = " + maBan + "", connect);
                if (cmd2.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đặt bàn thành công");
                   Hide();
                    Main m = new Main();
                    m.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
            connect.Close();
        }
    }
}
