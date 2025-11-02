using System;
using System.Data;
using System.Windows.Forms;
using DA_2ENTREGA_DEF;
using DA_ENTREGA2_DEF;
using MySql.Data.MySqlClient;

namespace DA_ENTREGA2_DEF
{
    public partial class SoftDelete : Form
    {
        private Langilea langilea;

        public SoftDelete(Langilea l)
        {
            InitializeComponent();
            langilea = l;
            this.Load += new EventHandler(erabiltzaileakKudeatu_Load);
            KargatuErabiltzaileak();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void KargatuErabiltzaileak()
        {
            Konexioa konexioa = new Konexioa();

            // Solo usuarios con is_deleted = 1
            string kontsulta = @"SELECT izena AS 'Izena', 
                                        abizena1 AS 'Lehen abizena', 
                                        abizena2 AS 'Bigarren abizena', 
                                        nan AS 'NAN-a', 
                                        jaiotza_data AS 'Jaiotza data', 
                                        posta_elektronikoa AS 'Posta elektronikoa', 
                                        telefono_zenbakia AS 'Telefono zenbakia', 
                                        helbidea AS 'Helbidea' 
                                 FROM erabiltzaileak 
                                 WHERE is_deleted = 1;";

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
                MessageBox.Show("Errorea datuak kargatzean: " + ex.Message);
            }
        }

        private void erabiltzaileakKudeatu_Load(object sender, EventArgs e)
        {
            this.Text = "Ongi etorri, " + langilea.erabiltzaile_izena;
        }

        private void ezabatu_BTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                string nan = fila.Cells["NAN-a"].Value.ToString();

                ErabiltzaileaEzabatu.ErabiltzaileakEzabatu(nan);

                KargatuErabiltzaileak();
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu erabiltzaile bat ezabatzeko.");
            }
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
                Editatu ed = new Editatu(izena, abizena1, abizena2, nan, jaiotza_data, posta, telefono, helbidea);
                ed.ShowDialog();

                KargatuErabiltzaileak();
            }
        }

        private void atzera_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Métodos vacíos heredados
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void erabiltzaileakKudeatu_Load_1(object sender, EventArgs e) { }
        
        private void errekuperatu_BTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                string nan = fila.Cells["NAN-a"].Value.ToString();

                Errekuperatu.erabiltzaileaErrekuperatu(nan);

                KargatuErabiltzaileak();
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu erabiltzaile bat ezabatzeko.");
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
