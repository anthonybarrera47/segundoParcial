using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
    public class VendedorDetalle
    {
        [Key]
        public int ID { get; set; }
        public int VendedorID { get; set; }
        public int MetaID { get; set; }
        public Double Cuota { get; set; }

        public VendedorDetalle()
        {
            ID = 0;
            VendedorID = 0;
            MetaID = 0;
            Cuota = 0;
        }
        public VendedorDetalle(int ID,int VendedorID,int MetaID, Double Cuota)
        {
            this.ID = ID;
            this.VendedorID = VendedorID;
            this.MetaID = MetaID;
            this.Cuota = Cuota;
        }
    }
}
