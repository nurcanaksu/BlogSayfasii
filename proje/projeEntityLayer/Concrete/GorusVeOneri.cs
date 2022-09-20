using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace projeEntityLayer.Concrete
{
    public class GorusVeOneri
    {
        [Key]
        public int GorusID { get; set; }
        public string KullanicininAdi { get; set; }
        public string KullanicininSoyadi { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciYorum { get; set; }
    }
}
