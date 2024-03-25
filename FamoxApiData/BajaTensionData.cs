using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class BajaTensionData
    {
        public static List<BajaTension> ListaBajaTension()
        {
            var db = new FamoxApiContext();
            return db.BajaTensiones.OrderBy(x => x.Id).ToList();
        }
        public static BajaTension ObtenerBajaTension(int IdBajaTension)
        {
            var db = new FamoxApiContext();
            return db.BajaTensiones.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdBajaTension);
        }
        public static void CrearBajaTension(BajaTension bajaTension)
        {
            using (var context = new FamoxApiContext())
            {
                context.BajaTensiones.Add(bajaTension);
                context.SaveChanges();
            }
        }
        public static void ModificarBajaTension(BajaTension bajaTension)
        {
            using (var context = new FamoxApiContext())
            {
                var bajaTensionEditado = context.BajaTensiones.Where(x => x.Id.Equals(bajaTension.Id)).Single();
                bajaTensionEditado.BajaTension_ = bajaTension.BajaTension_;
                context.Entry(bajaTensionEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarBajaTension(int IdBajaTension)
        {
            using (var context = new FamoxApiContext())
            {
                var bajaTension = context.BajaTensiones.Where(x => x.Id.Equals(IdBajaTension)).Single();

                context.Remove(bajaTension);
                context.SaveChanges();
            }
        }
    }
}
