using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Takim
    {
        [Key]
        public int TakimId { get; set; }

        public string TakimAdi { get; set; }
        //
        //
        //Maçta Listelenecek (Ev sahibi Takım)
        public virtual IList<Mac> EvMac { get; set; }
        //
        //
        //Maçta Listelenecek (Deplesman Takımı)
        public virtual IList<Mac> KonukMac { get; set; }
    }
}
