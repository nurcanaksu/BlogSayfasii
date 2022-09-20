using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace projeEntityLayer.Concrete
{
    public class EkranGoruntuleri
    {
        [Key]
        public int EkranGoruntuID { get; set; }
        public string EkranGoruntusu { get; set; }
    }
}
