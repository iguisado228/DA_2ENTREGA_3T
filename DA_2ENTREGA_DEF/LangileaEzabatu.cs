using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_2ENTREGA_DEF
{
    internal class LangileaEzabatu
    {

        public static void langileaEzabatu(string nan)
        {
            DialogResult respuesta = MessageBox.Show(
                "Ziur zaude erabiltzaile hau ezabatu nahi duzula?",
                "Berrespena",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                Konexioa konexioa = new Konexioa();

                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    string query = "DELETE FROM langileak WHERE nan = @nan";

                    using (MySqlCommand cmd = new MySqlCommand(query, kon))
                    {
                        cmd.Parameters.AddWithValue("@nan", nan);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Erabiltzailea ezabatu da.");
                        }
                        else
                        {
                            MessageBox.Show("Ez da erabiltzaile hori aurkitu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea ezabitzean: " + ex.Message);
            }
        }
    }
}
