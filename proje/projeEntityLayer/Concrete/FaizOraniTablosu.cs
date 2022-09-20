using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace projeEntityLayer.Concrete
{
    public class FaizOraniTablosu
    {
        [Key]
        public int FaizOraniID { get; set; }
        public string FaizOraniAdi { get; set; }
    }
}
