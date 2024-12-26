using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_Management.Model.Entity
{
    public class Jadwal
    {
        public string  Maskapai {  get; set; }
        public string JenisPesawat { get; set; }
        public string WaktuKeberangkatan { get; set; }
        public string WaktuSampai { get; set; }
        public double Harga { get; set; }
        public string Asal { get; set; }
        public string Tujuan { get; set; }
    }
}
