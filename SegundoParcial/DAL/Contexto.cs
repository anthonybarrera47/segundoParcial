using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Metas> Meta { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
