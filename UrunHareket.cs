using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUygulamasi
{
    public class UrunHareket
    {
        public string MasaKodu { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public string Birimi { get; set; }
        public double Fiyat { get; set; }
        public double Miktar { get; set; }
    }
}
