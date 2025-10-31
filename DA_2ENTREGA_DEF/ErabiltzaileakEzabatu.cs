using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_2ENTREGA_DEF;
using static DA_2ENTREGA_DEF.Konexioa;

namespace DA_2ENTREGA_DEF
{
    public static class ErabiltzaileaEzabatu
    {
        public static void ErabiltzaileakEzabatu(string nan)
        {
            DialogResult erantzuna = MessageBox.Show(
                "Ziur zaude erabiltzaile hau behin betiko ezabatu nahi duzula?",
                "Berrespena",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (erantzuna != DialogResult.Yes)
                return;

            try
            {
                Konexioa konexioa = new Konexioa();

                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    string query = "DELETE FROM erabiltzaileak WHERE nan = @nan";

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
                MessageBox.Show("Errorea erabiltzailea ezabitzerakoan: " + ex.Message);
            }
        }
    }
}
