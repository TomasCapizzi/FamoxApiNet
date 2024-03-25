using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class ModeloEquipoDigitalData
    {
        public static List<ModeloEquipoDigital> ListaModeloEquipoDigital()
        {
            var db = new FamoxApiContext();
            return db.ModelosEquiposDigitales.OrderBy(x => x.Id).ToList();
        }
        public static ModeloEquipoDigital ObtenerModeloEquipoDigital(int IdModeloEquipoDigital)
        {
            var db = new FamoxApiContext();
            return db.ModelosEquiposDigitales.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdModeloEquipoDigital);
        }
        public static void CrearModeloEquipoDigital(ModeloEquipoDigital modeloEquipoDigital)
        {
            using (var context = new FamoxApiContext())
            {
                context.ModelosEquiposDigitales.Add(modeloEquipoDigital);
                context.SaveChanges();
                context.SaveChanges();
            }
        }
        public static void ModificarModeloEquipoDigital(ModeloEquipoDigital modeloEquipoDigital)
        {
            using (var context = new FamoxApiContext())
            {
                var modeloEquipoDigitalEditado = context.ModelosEquiposDigitales.Where(x => x.Id.Equals(modeloEquipoDigital.Id)).Single();
                modeloEquipoDigitalEditado.Nombre = modeloEquipoDigital.Nombre;
                modeloEquipoDigitalEditado.Uso = modeloEquipoDigital.Uso;
                modeloEquipoDigitalEditado.Origen = modeloEquipoDigital.Origen;
                modeloEquipoDigitalEditado.Img = modeloEquipoDigital.Img;
                modeloEquipoDigitalEditado.Modulos = modeloEquipoDigital.Modulos;
                modeloEquipoDigitalEditado.Codigo = modeloEquipoDigital.Codigo;
                context.Entry(modeloEquipoDigitalEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarModeloEquipoDigital(int IdModeloEquipoDigital)
        {
            using (var context = new FamoxApiContext())
            {
                var modeloEquipoDigital = context.ModelosEquiposDigitales.Where(x => x.Id.Equals(IdModeloEquipoDigital)).Single();

                context.Remove(modeloEquipoDigital);
                context.SaveChanges();
            }
        }
    }
}
