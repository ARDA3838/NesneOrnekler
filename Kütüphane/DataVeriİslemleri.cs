using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Kütüphane
{
    class DataVeriİslemleri
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
