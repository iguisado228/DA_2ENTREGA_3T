using DA_2ENTREGA_DEF;
using System;
using System.Windows.Forms;
using static DA_2ENTREGA_DEF.ErabiltzaileakKudeatu;

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
          
            ErabiltzaileakKudeatu kudeaketa = new ErabiltzaileakKudeatu(langilea);
            kudeaketa.ShowDialog();
            this.Show();
        }

        private void atera_BTN_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void langileakKudeatu_BTN_Click(object sender, EventArgs e)
        {

            this.Hide();
            langileakKudeatu LangileKudeaketa = new langileakKudeatu(langilea);
            LangileKudeaketa.ShowDialog();
            this.Show();

        }

        private void erabiltzaileakEzabatu_Click(object sender, EventArgs e)
        {
           // softDelete sd = new softDelete(langilea);
           // sd.ShowDialog();

        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
