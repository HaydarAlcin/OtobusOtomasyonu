using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otobus_otomasyon
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilet_iptal bip = new bilet_iptal();
            bip.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            biletal al = new biletal();
            al.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
        }
    }
}
