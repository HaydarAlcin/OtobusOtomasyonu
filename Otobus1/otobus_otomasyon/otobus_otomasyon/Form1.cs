using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace otobus_otomasyon
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0H14M1G\SQLEXPRESS;Initial Catalog=otobus;Integrated Security=True");
        public static string k_adi="";
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand listeleseans = new SqlCommand("select * from admin where k_adi='" + textBox4.Text + "' and sifre='"+textBox3.Text+"'", baglanti);
            SqlDataReader drs = listeleseans.ExecuteReader();
            if (drs.Read())
            {
                k_adi = drs["k_adi"].ToString();
                admin_panel ap = new admin_panel();
                ap.Show();
                this.Hide();

            }
            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
