using DA_ENTREGA2_DEF;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_2ENTREGA_DEF;


namespace DA_2ENTREGA_DEF
{
    public partial class langileakKudeatu : Form
    {
        private Langilea langilea;

        public langileakKudeatu(Langilea l)
        {
            InitializeComponent();
            langilea = l;
            this.Load += new EventHandler(langileakKudeatu_Load);
            KargatuLangileak();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void KargatuLangileak()
        {
           Konexioa konexioa = new Konexioa();

            string kontsulta = @"
                SELECT 
                    izena AS 'Izena',
                    abizena1 AS 'Lehen abizena',
                    abizena2 AS 'Bigarren abizena',
                    nan AS 'NAN-a',
                    jaiotza_data AS 'Jaiotza data',
                    posta_elektronikoa AS 'Posta elektronikoa',
                    telefono_zenbakia AS 'Telefono zenbakia',
                    helbidea AS 'Helbidea'
                FROM langileak";

            try
            {
                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(kontsulta, kon))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea langileen datuak kargatzean: " + ex.Message);
            }
        }

        private void langileakKudeatu_Load(object sender, EventArgs e)
        {
            this.Text = "Ongi etorri, " + langilea.erabiltzaile_izena;
        }

        private void ezabatu_BTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                string nan = fila.Cells["NAN-a"].Value.ToString();

                LangileaEzabatu.langileaEzabatu(nan);

                KargatuLangileak();
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu langile bat ezabatzeko.");
            }
        }

        private void sortu_BTN_Click(object sender, EventArgs e)
        {
            LangileaSortu s = new LangileaSortu(); 
            s.ShowDialog();

            KargatuLangileak();
        }

        private void editatu_BTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                string izena = fila.Cells["Izena"].Value.ToString();
                string abizena1 = fila.Cells["Lehen abizena"].Value.ToString();
                string abizena2 = fila.Cells["Bigarren abizena"].Value.ToString();
                string nan = fila.Cells["NAN-a"].Value.ToString();
                string jaiotza_data = fila.Cells["Jaiotza data"].Value.ToString();
                string posta = fila.Cells["Posta elektronikoa"].Value.ToString();
                string telefono = fila.Cells["Telefono zenbakia"].Value.ToString();
                string helbidea = fila.Cells["Helbidea"].Value.ToString();

                LangileaEditatu ed = new LangileaEditatu(izena, abizena1, abizena2, nan, jaiotza_data, posta, telefono, helbidea);
                ed.ShowDialog();

                KargatuLangileak();
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu langile bat editatzeko.");
            }
        }

        private void atzera_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
