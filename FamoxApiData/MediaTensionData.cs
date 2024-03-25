using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class MediaTensionData
    {
        public static List<MediaTension> ListaMediaTension()
        {
            var db = new FamoxApiContext();
            return db.MediaTensiones.OrderBy(x => x.Id).ToList();
        }
        public static MediaTension ObtenerMediaTension(int IdMediaTension)
        {
            var db = new FamoxApiContext();
            return db.MediaTensiones.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdMediaTension);
        }
        public static void CrearMediaTension(MediaTension mediaTension)
        {
            using (var context = new FamoxApiContext())
            {
                context.MediaTensiones.Add(mediaTension);
                context.SaveChanges();
                context.SaveChanges();
            }
        }
        public static void ModificarMediaTension(MediaTension mediaTension)
        {
            using (var context = new FamoxApiContext())
            {
                var mediaTensionEditado = context.MediaTensiones.Where(x => x.Id.Equals(mediaTension.Id)).Single();
                mediaTensionEditado.MediaTension_ = mediaTension.MediaTension_;
                context.Entry(mediaTensionEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarMediaTension(int IdMediaTension)
        {
            using (var context = new FamoxApiContext())
            {
                var mediaTension = context.MediaTensiones.Where(x => x.Id.Equals(IdMediaTension)).Single();

                context.Remove(mediaTension);
                context.SaveChanges();
            }
        }
    }
}
