using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
    public class Vendedor
    {
        [Key]
        public int VendedorID { get; set; }
        public String Nombres { get; set; }
        public Double Sueldo { get; set; }
        public float RetencionPorcentaje { get; set; }
        public String RetencionCalculo { get; set; }
        public DateTime Fecha { get; set; }
        

        public virtual List<VendedorDetalle> Meta { get; set; }
        public Vendedor()
        {
            VendedorID = 0;
            Nombres = string.Empty;
            Sueldo = 0;
            RetencionPorcentaje = 0;
            RetencionCalculo = string.Empty;
            Fecha = DateTime.Now;
            Meta = new List<VendedorDetalle>();
        }
    }
}
