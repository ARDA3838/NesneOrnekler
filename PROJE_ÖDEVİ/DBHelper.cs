using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_ÖDEVİ
{
    class DBHelper
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
