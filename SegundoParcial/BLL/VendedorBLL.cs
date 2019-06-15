using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.BLL
{
    public class VendedorBLL
    {
        static RepositorioBase<Metas> repositorio;
        public static bool Guardar(Vendedor vendedor)
        {
            repositorio = new RepositorioBase<Metas>();
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                foreach (var item in vendedor.Meta)
                {
                    var cuota = db.Meta.Find(item.MetaID);
                    cuota.Cuota -= item.Cuota;
                }
                if (db.Vendedor.Add(vendedor) != null)
                      paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {throw;}
            finally
            {db.Dispose();}
            return paso;
        }

        public static bool Modificar(Vendedor vendedor)
        {
            bool paso = false;
            var Anterior = VendedorBLL.Buscar(vendedor.VendedorID);
            Contexto db = new Contexto();
            try
            {
                foreach (var item in Anterior.Meta)
                {
                    var cuota = db.Meta.Find(item.MetaID);
                    if (!vendedor.Meta.Exists(d => d.ID == item.ID))
                    {
                        cuota.Cuota += item.Cuota;
                        db.Entry(item).State = EntityState.Deleted;
                    }
                    
                }
                foreach (var item in vendedor.Meta)
                {
                    var estado = System.Data.Entity.EntityState.Unchanged;
                    /*var estado = (item.ID == 0) ? EntityState.Added : EntityState.Modified;
                    db.Entry(item).State = estado;*/
                    if (item.ID == 0)
                    {
                        var cuota = db.Meta.Find(item.MetaID);
                        cuota.Cuota -= item.Cuota;
                        estado = EntityState.Added;
                    } 
                    else
                        estado = EntityState.Modified;
                    db.Entry(item).State = estado;    
                }
                db.Entry(vendedor).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;  
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;
        }
       
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Vendedor.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;
        }

        public static Vendedor Buscar(int id)
        {
            var vendedor = new Vendedor();
            Contexto db = new Contexto();
            try
            {
                vendedor = db.Vendedor.Find(id);
                if (vendedor == null)
                    return vendedor;
                vendedor.Meta.Count();
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return vendedor;
        }

        public static List<Vendedor> GetList(Expression<Func<Vendedor, bool>> expression)
        {
            List<Vendedor> Lista = new List<Vendedor>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Vendedor.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
