using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ENTREGA2_DEF
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void TXT_erabiltzailea_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_pasahitza_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_sartu_Click(object sender, EventArgs e)
        {
            string erabiltzailea = TXT_erabiltzailea.Text;
            string pasahitza = TXT_pasahitza.Text;

            langilea l = new langilea(erabiltzailea, pasahitza);

            if (l.langileaLogin())
            {
                //Menu men = new Menu(l);
                //men.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erabiltzaile edo pasahitza ez dira zuzenak.");
            }
        }

        private void LBL_erabiltzailea_Click(object sender, EventArgs e)
        {

        }

        private void LBL_pasahitza_Click(object sender, EventArgs e)
        {

        }

        private void atera_BTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
