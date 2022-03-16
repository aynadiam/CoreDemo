using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mac
    {
        [Key]
        public int MacId { get; set; }

        public string MacTarihi { get; set; }

        public string Stadyum { get; set; }
        //
        //
        //Maçın Bir Ev Sahibi Takımı Olacak
        public int? EvTakimId { get; set; }
        public virtual Takim EvTakim { get; set; }
        //
        //
        //Maçın Bir Misafir Takımı Olacak
        public int? KonukTakimId { get; set; }
        public virtual Takim KonukTakim { get; set; }
    }
}
