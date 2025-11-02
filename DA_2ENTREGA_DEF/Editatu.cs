using DA_2ENTREGA_DEF;
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

namespace DA_ENTREGA2_DEF
{
    public partial class Editatu : Form
    {
        private string erabiltzaileNan;

        public Editatu(
            string izena, string abizena1, string abizena2, string nan, string jaiotza_data,
            string posta, string telefono, string helbidea)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            erabiltzaileNan = nan;

            txtIzena.Text = izena;
            txtAbizena1.Text = abizena1;
            txtAbizena2.Text = abizena2;
            txtNan.Text = nan;
            txtJaiotzaData.Text = jaiotza_data;
            txtPosta.Text = posta;
            txtTelefono.Text = telefono;
            txtHelbidea.Text = helbidea;
        }

        private void editatu_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                Konexioa konexioa = new Konexioa();

                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    string query = @"UPDATE erabiltzaileak 
                                    SET izena = @izena,
                                        abizena1 = @abizena1,
                                        abizena2 = @abizena2,
                                        nan = @nan,
                                        jaiotza_data = @jaiotza_data,
                                        posta_elektronikoa = @posta,
                                        telefono_zenbakia = @telefono,
                                        helbidea = @helbidea
                                    WHERE nan = @erabiltzaileNan";

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
                        cmd.Parameters.AddWithValue("@erabiltzaileNan", erabiltzaileNan);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Erabiltzailea eguneratu da!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea eguneratzean: " + ex.Message);
            }
        }

        private void Editatu_Load(object sender, EventArgs e)
        {

        }

        private void txtJaiotzaData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Editatu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
