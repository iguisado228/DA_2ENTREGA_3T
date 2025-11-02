using System;
using System.IO;

namespace DA_ENTREGA2_DEF
{
    internal class Erregistroa
    {
        private static readonly string erregistroaBidea = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "erregistro_aldaketak.txt");

        /// <summary>
        /// Aldaketa bat erregistratzen du testu-fitxategi batean.
        /// </summary>
        /// <param name="erabiltzailea">Aldaketa egin duen erabiltzailea</param>
        /// <param name="ekintza">Egindako ekintza (Insert, Update, Delete...)</param>
        /// <param name="helburukoErabiltzailea">Aldaketa jasan duen erabiltzailea (adibidez, NANA edo izena)</param>
        internal static void AldaketaErregistratu(string erabiltzailea, string ekintza, string helburukoErabiltzailea)
        {
            try
            {
                using (StreamWriter idazlea = new StreamWriter(erregistroaBidea, true))
                {
                    idazlea.WriteLine("===============================================");
                    idazlea.WriteLine($"Data eta ordua: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    idazlea.WriteLine($"Aldaketa egin duen erabiltzailea: {erabiltzailea}");
                    idazlea.WriteLine($"Ekintza mota: {ekintza}");
                    idazlea.WriteLine($"Helburuko erabiltzailea: {helburukoErabiltzailea}");
                    idazlea.WriteLine("===============================================");
                    idazlea.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea erregistroan idazterakoan: " + ex.Message);
            }
        }
    }
}
