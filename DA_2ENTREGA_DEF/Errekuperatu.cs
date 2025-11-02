using DA_2ENTREGA_DEF;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DA_ENTREGA2_DEF
{
    public static class Errekuperatu
    {
        public static void erabiltzaileaErrekuperatu(string nan)
        {
            DialogResult respuesta = MessageBox.Show(
                "Ziur zaude erabiltzaile hau errekuperatu nahi duzula?",
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

                    // Soft delete: actualizamos is_deleted a 1
                    string query = "UPDATE erabiltzaileak SET is_deleted = 0 WHERE nan = @nan";

                    using (MySqlCommand cmd = new MySqlCommand(query, kon))
                    {
                        cmd.Parameters.AddWithValue("@nan", nan);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Erabiltzailean errekuperatu egin da.");
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
                MessageBox.Show("Errorea erabiltzailean errekuperatzean: " + ex.Message);
            }
        }
    }
}
