using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarApp8523.Models
{
    public class Bilgisayar
    {
        public int Id { get; set; }
        public string Marka { get; set; }

        public string Model { get; set; }

        public double GHz { get; set; }
        public short Hafiza { get; set; }

        public double Inc { get;  set; }

        public bool SuSogutmaliMi { get; set; }

        public DateTime UretimTarihi { get; set; }

        public BilgisayarTipi BilgisayarTipi { get; set; }
    }
}
