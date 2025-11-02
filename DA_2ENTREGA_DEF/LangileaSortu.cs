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
    public partial class LangileaSortu : Form
    {
        public LangileaSortu()
        {
            InitializeComponent();
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

                    string query = @"
                        INSERT INTO langileak 
                        (izena, abizena1, abizena2, nan, jaiotza_data, posta_elektronikoa, telefono_zenbakia, helbidea, erabiltzaile_izena, pasahitza, arduraduna)
                        VALUES 
                        (@izena, @abizena1, @abizena2, @nan, @jaiotza_data, @posta, @telefono, @helbidea, @erabiltzaile_izena, @pasahitza, @arduraduna)";

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


                        cmd.Parameters.AddWithValue("@erabiltzaile_izena", txtErabiltzaileIzena.Text);
                        cmd.Parameters.AddWithValue("@pasahitza", txtPasahitza.Text);
                        cmd.Parameters.AddWithValue("@arduraduna", chkArduraduna.Checked);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Erabiltzailea gehitu da!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea gehitzean: " + ex.Message);
            }
        }

        private void LangileaSortu_Load(object sender, EventArgs e)
        {

        }
    }
}
