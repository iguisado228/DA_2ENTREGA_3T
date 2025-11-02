using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using DA_2ENTREGA_DEF;
using DA_ENTREGA2_DEF;

namespace DA_ENTREGA2_DEF
{
    public partial class Sortu : Form
    {
        private Langilea langilea;


        public Sortu(Langilea l)
        {
            InitializeComponent();
            langilea = l;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void insertatu_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                Konexioa konexioa = new Konexioa();

                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    string query = @"INSERT INTO erabiltzaileak 
                                    (izena, abizena1, abizena2, nan, jaiotza_data, posta_elektronikoa, telefono_zenbakia, helbidea) 
                                    VALUES (@izena, @abizena1, @abizena2, @nan, @jaiotza_data, @posta, @telefono, @helbidea)";

                    using (MySqlCommand cmd = new MySqlCommand(query, kon))
                    {
                        cmd.Parameters.AddWithValue("@izena", txtIzena.Text);
                        cmd.Parameters.AddWithValue("@abizena1", txtAbizena1.Text);
                        cmd.Parameters.AddWithValue("@abizena2", txtAbizena2.Text);
                        cmd.Parameters.AddWithValue("@nan", txtNan.Text);

                        DateTime jaiotzaData;
                        if (DateTime.TryParse(txtJaiotzaData.Text, out jaiotzaData))
                        {
                            cmd.Parameters.AddWithValue("@jaiotza_data", jaiotzaData);
                        }
                        else
                        {
                            MessageBox.Show("Jaiotza data ez da baliozkoa (formatoa: yyyy-MM-dd).");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@posta", txtPosta.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@helbidea", txtHelbidea.Text);

                        cmd.ExecuteNonQuery();
                    }
                }


                Erregistroa.AldaketaErregistratu(
                    langilea.erabiltzaile_izena,
                    "INSERT",
                    txtNan.Text
                );

                MessageBox.Show("Erabiltzailea gehitu da!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea gehitzean: " + ex.Message);
            }
        }

        private void Sortu_Load(object sender, EventArgs e)
        {

        }
    }
}
