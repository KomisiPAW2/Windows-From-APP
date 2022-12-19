using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=yourStrong(!)Password");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Test values (@NIM,@Nama,@Kelas)", con);
            cmd.Parameters.AddWithValue("@NIM",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama", textBox2.Text);
            cmd.Parameters.AddWithValue("@Kelas", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil ditambahkan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=yourStrong(!)Password");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  dbo.Test set Nama=@Nama,Kelas=@Kelas where NIM=@NIM", con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama", textBox2.Text);
            cmd.Parameters.AddWithValue("@Kelas", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil diperbarui");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=yourStrong(!)Password");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete dbo.Test where NIM=@NIM", con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil dihapus");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=yourStrong(!)Password");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from dbo.Test where NIM=@NIM", con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
    
}
