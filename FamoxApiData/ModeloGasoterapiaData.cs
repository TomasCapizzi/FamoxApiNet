using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class ModeloGasoterapiaData
    {
        public static List<ModeloGasoterapia> ListaModelosGasoterapia()
        {
            var db = new FamoxApiContext();
            return db.ModelosGasoterapia.OrderBy(x => x.Id).ToList();
        }
        public static ModeloGasoterapia ObtenerModeloGasoterapia(int IdModeloGasoterapia)
        {
            var db = new FamoxApiContext();
            return db.ModelosGasoterapia.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdModeloGasoterapia);
        }
        public static void CrearModeloGasoterapia(ModeloGasoterapia modeloGasoterapia)
        {
            using (var context = new FamoxApiContext())
            {
                context.ModelosGasoterapia.Add(modeloGasoterapia);
                context.SaveChanges();
                context.SaveChanges();
            }
        }
        public static void ModificarModeloGasoterapia(ModeloGasoterapia modeloGasoterapia)
        {
            using (var context = new FamoxApiContext())
            {
                var modeloGasoterapiaEditado = context.ModelosGasoterapia.Where(x => x.Id.Equals(modeloGasoterapia.Id)).Single();
                modeloGasoterapiaEditado.Nombre = modeloGasoterapia.Nombre;
                modeloGasoterapiaEditado.Uso = modeloGasoterapia.Uso;
                modeloGasoterapiaEditado.Rango = modeloGasoterapia.Rango;
                modeloGasoterapiaEditado.Img = modeloGasoterapia.Img;
                modeloGasoterapiaEditado.Origen = modeloGasoterapia.Origen;
                context.Entry(modeloGasoterapiaEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarModeloGasoterapia(int IdModeloGasoterapia)
        {
            using (var context = new FamoxApiContext())
            {
                var modeloGasoterapia = context.ModelosGasoterapia.Where(x => x.Id.Equals(IdModeloGasoterapia)).Single();

                context.Remove(modeloGasoterapia);
                context.SaveChanges();
            }
        }
    }
}
