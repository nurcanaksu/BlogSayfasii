using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace projeEntityLayer.Concrete
{
    public class DemoIndirmeSayfasi
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciTelno { get; set; }
        public string KullaniciSehir { get; set; }
    }
}
