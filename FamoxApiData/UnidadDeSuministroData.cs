using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class UnidadDeSuministroData
    {
        public static List<UnidadDeSuministro> ListaUnidadDeSuministro()
        {
            var db = new FamoxApiContext();
            return db.UnidadesDeSuministros.OrderBy(x => x.Id).ToList();
        }
        public static UnidadDeSuministro ObtenerUnidadDeSuministro(int IdUnidadDeSuministro)
        {
            var db = new FamoxApiContext();
            return db.UnidadesDeSuministros.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdUnidadDeSuministro);
        }
        public static void CrearUnidadDeSuministro(UnidadDeSuministro unidadDeSuministro)
        {
            using (var context = new FamoxApiContext())
            {
                context.UnidadesDeSuministros.Add(unidadDeSuministro);
                context.SaveChanges();
            }
        }
        public static void ModificarUnidadDeSuministro(UnidadDeSuministro unidadDeSuministro)
        {
            using (var context = new FamoxApiContext())
            {
                var unidadDeSuministroEditado = context.UnidadesDeSuministros.Where(x => x.Id.Equals(unidadDeSuministro.Id)).Single();
                unidadDeSuministroEditado.Nombre = unidadDeSuministro.Nombre;
                unidadDeSuministroEditado.Uso = unidadDeSuministro.Uso;
                unidadDeSuministroEditado.Anmat = unidadDeSuministro.Anmat;
                unidadDeSuministroEditado.Img = unidadDeSuministro.Img;
                unidadDeSuministroEditado.Conexion = unidadDeSuministro.Conexion;
                unidadDeSuministroEditado.Gas = unidadDeSuministro.Gas;
                unidadDeSuministroEditado.Modelos = unidadDeSuministro.Modelos;
                unidadDeSuministroEditado.Gasoterapia = unidadDeSuministro.Gasoterapia;
                unidadDeSuministroEditado.MediaTension = unidadDeSuministro.MediaTension;
                unidadDeSuministroEditado.BajaTension = unidadDeSuministro.BajaTension;
                unidadDeSuministroEditado.Conectores = unidadDeSuministro.Conectores;
                unidadDeSuministroEditado.Gases = unidadDeSuministro.Gases;
                unidadDeSuministroEditado.Orden = Convert.ToInt32(unidadDeSuministro.Orden);
                unidadDeSuministroEditado.Manual = unidadDeSuministro.Manual;
                unidadDeSuministroEditado.Longitud = unidadDeSuministro.Longitud;
                unidadDeSuministroEditado.Iluminacion = unidadDeSuministro.Iluminacion;
                context.Entry(unidadDeSuministroEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarUnidadDeSuministro(int IdUnidadDeSuministro)
        {
            using (var context = new FamoxApiContext())
            {
                var unidadDeSuministro = context.UnidadesDeSuministros.Where(x => x.Id.Equals(IdUnidadDeSuministro)).Single();

                context.Remove(unidadDeSuministro);
                context.SaveChanges();
            }
        }
    }
}
