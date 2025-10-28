using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using DA_2ENTREGA_DEF;

namespace DA_ENTREGA2_DEF
{
    public class langilea
    {
        public int id_langilea { get; set; }
        public string izena { get; set; }
        public string abizena1 { get; set; }
        public string abizena2 { get; set; }
        public string nan { get; set; }
        public string jaiotza_data { get; set; }
        public string posta_elektronikoa { get; set; }
        public string telefono_zenbakia { get; set; }
        public string helbidea { get; set; }
        public string erabiltzaile_izena { get; set; }
        public string pasahitza { get; set; }
        public string arduraduna { get; set; }

        public langilea(string erabiltzaile, string pasahitz)
        {
            this.erabiltzaile_izena = erabiltzaile;
            this.pasahitza = pasahitz;
        }

        public bool langileaLogin()
        {
            bool loginaEginda = false;
            konexioa k = new konexioa();
            k.konektatu();

            if (k.conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = k.conn;
                    command.CommandText = "SELECT id_langilea FROM langileak WHERE erabiltzaile_izena = @valor1 AND pasahitza = @valor2";
                    command.Parameters.AddWithValue("@valor1", erabiltzaile_izena);
                    command.Parameters.AddWithValue("@valor2", pasahitza);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        id_langilea = reader.GetInt32("id_langilea");
                        loginaEginda = true;
                    }
                    else
                    {
                        MessageBox.Show("Erabiltzaile edo pasahitza ez dira zuzenak.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea loginean: " + ex.Message);
                }
                k.conn.Close();
            }
            return loginaEginda;
        }
    }
}
