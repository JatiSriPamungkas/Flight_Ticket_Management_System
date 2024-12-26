using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_Management.Model.Entity
{
    public class Penumpang
    {
        public string NamaLengkap { get; set; }
        public string NoIdentitas { get; set; }
        public string TanggalLahir { get; set; }
        public string Alamat {  get; set; }
        public string NomorTelepon { get; set; }
        public string Email { get; set; }
        public string JenisKelamin { get; set; }
        public string Kewarganegaraan { get; set; }
        public string Keberangkatan { get; set; }
        public string Tujuan { get; set; }
        public string Kelas {  get; set; }
        public string JumlahPenumpang { get; set; }
    }
}
