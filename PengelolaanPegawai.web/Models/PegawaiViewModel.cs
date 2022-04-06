using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PengelolaanPegawai.web.Models
{
    public class PegawaiViewModel
    {
        public string NIP { get; set; }
        public string NamaDivisi { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public DateTime TanggalLahir { get; set; }
    }
}