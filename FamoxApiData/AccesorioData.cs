using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamoxApiEntities;

namespace FamoxApiData
{
    public static class AccesorioData
    {
        public static List<Accesorio> ListaAccesorios()
        {
            var db = new FamoxApiContext();
            return db.Accesorios.OrderBy(x => x.Id).ToList();
        }
        public static Accesorio ObtenerAccesorio(int IdAccesorio)
        {
            var db = new FamoxApiContext();
            return db.Accesorios.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdAccesorio);
        }
        public static void CrearAccesorio(Accesorio accesorio)
        {
            using (var context = new FamoxApiContext())
            {
                context.Accesorios.Add(accesorio);
                context.SaveChanges();
            }
        }
        public static void ModificarAccesorio(Accesorio accesorio)
        {
            using (var context = new FamoxApiContext())
            {
                var accesorioEditado = context.Accesorios.Where(x => x.Id.Equals(accesorio.Id)).Single();
                accesorioEditado.Nombre = accesorio.Nombre;
                accesorioEditado.Descripcion = accesorio.Descripcion;
                accesorioEditado.Img = accesorio.Img;
                accesorioEditado.Accesorio_ = accesorio.Accesorio_;
                accesorioEditado.Manual = accesorio.Manual;
                accesorioEditado.Gases = accesorio.Gases;
                accesorioEditado.AccesorioUS = accesorio.AccesorioUS;
                context.Entry(accesorioEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarAccesorio(int IdAccesorio)
        {
            using (var context = new FamoxApiContext())
            {
                var accesorio = context.Accesorios.Where(x => x.Id.Equals(IdAccesorio)).Single();

                context.Remove(accesorio);
                context.SaveChanges();
            }
        }
    }
}
