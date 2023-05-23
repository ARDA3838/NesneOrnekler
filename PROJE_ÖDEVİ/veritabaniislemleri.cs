using MySql.Data.MySqlClient;
using System.Configuration;

namespace PROJE_ÖDEVİ
{
    internal class veritabaniislemleri
    {
        string baglantiCümlesi = ConfigurationManager.ConnectionStrings["randevu"].ConnectionString;

        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiCümlesi);

            MySqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}