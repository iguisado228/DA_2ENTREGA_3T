using System;
using System.Windows.Forms;

namespace DA_ENTREGA2_DEF
{
    public partial class Menu : Form
    {
        private Langilea langilea;

        public Menu(Langilea l)
        {
            InitializeComponent();
            langilea = l;
            this.Load += new EventHandler(Menu_Load);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Ongi etorri, " + langilea.erabiltzaile_izena;
        }

        private void erabiltzaileakKudeatu_BTN_Click(object sender, EventArgs e)
        {
          
            //erabiltzaileakKudeatu kudeaketa = new erabiltzaileakKudeatu(langilea);
            //kudeaketa.ShowDialog();
        }

        private void atera_BTN_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void langileakKudeatu_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
           // langileakKudeatu l = new langileakKudeatu(langilea);
            //l.ShowDialog();
            this.Show();

        }

        private void erabiltzaileakEzabatu_Click(object sender, EventArgs e)
        {
           // softDelete sd = new softDelete(langilea);
           // sd.ShowDialog();

        }

        private void Menu_Load_2(object sender, EventArgs e)
        {

        }
    }
}
