using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace projeEntityLayer.Concrete
{
    public class Duyurular
    {   [Key]
        public int DuyuruID { get; set; }
        public string DuyuruBasligi { get; set; }
        public string DuyuruAciklama { get; set; }
        public DateTime DuyuruTarihi { get; set; }
    }
}
