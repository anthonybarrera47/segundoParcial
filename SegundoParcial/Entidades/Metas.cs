using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
    public class Metas
    {
        [Key]
        public int MetaID { get; set; }
        public String Descripcion { get; set; }
        public Double Cuota { get; set; }

        public Metas()
        {
            this.MetaID = 0;
            this.Descripcion = string.Empty;
            this.Cuota = 0;
        }
    }
}
