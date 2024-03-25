using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class ObraData
    {
        public static List<Obra> ListaObra()
        {
            var db = new FamoxApiContext();
            return db.Obras.OrderBy(x => x.Id).ToList();
        }
        public static Obra ObtenerObra(int IdObra)
        {
            var db = new FamoxApiContext();
            return db.Obras.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdObra);
        }
        public static void CrearObra(Obra obras)
        {
            using (var context = new FamoxApiContext())
            {
                context.Obras.Add(obras);
                context.SaveChanges();
            }
        }
        public static void ModificarObra(Obra obra)
        {
            using (var context = new FamoxApiContext())
            {
                var obraEditado = context.Obras.Where(x => x.Id.Equals(obra.Id)).Single();
                obraEditado.Obra_ = obra.Obra_;
                obraEditado.Img = obra.Img;
                obraEditado.Instalacion = obra.Instalacion;
                obraEditado.Fecha = Convert.ToInt32(obra.Fecha);
                context.Entry(obraEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarObra(int IdObra)
        {
            using (var context = new FamoxApiContext())
            {
                var obra = context.Obras.Where(x => x.Id.Equals(IdObra)).Single();

                context.Remove(obra);
                context.SaveChanges();
            }
        }
    }
}
