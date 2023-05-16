using MySql.Data.MySqlClient;
using System.Configuration;

namespace Kütüphane
{
    internal class VeriTabaniIslemleri
    {
        string baglantiCümlesi = ConfigurationManager.ConnectionStrings["kutuphaneBaglantiCumlesi"].ConnectionString;

        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiCümlesi);

            MySqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}