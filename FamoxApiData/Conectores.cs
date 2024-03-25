using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public class Conectores
    {
        public static List<Conector> ListaConectores()
        {
            var db = new FamoxApiContext();
            return db.Conectores.OrderBy(x => x.Id).ToList();
        }
        public static Conector ObtenerConector(int IdConector)
        {
            var db = new FamoxApiContext();
            return db.Conectores.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdConector);
        }
        public static void CrearConector(Conector conector)
        {
            using (var context = new FamoxApiContext())
            {
                context.Conectores.Add(conector);
                context.SaveChanges();
                context.SaveChanges();
            }
        }
        public static void ModificarConector(Conector conector)
        {
            using (var context = new FamoxApiContext())
            {
                var conectorEditado = context.Conectores.Where(x => x.Id.Equals(conector.Id)).Single();
                conectorEditado.Conector_ = conector.Conector_;
                context.Entry(conectorEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarConector(int IdConector)
        {
            using (var context = new FamoxApiContext())
            {
                var conector = context.Conectores.Where(x => x.Id.Equals(IdConector)).Single();

                context.Remove(conector);
                context.SaveChanges();
            }
        }
    }
}
