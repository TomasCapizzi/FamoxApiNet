using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class ModeloAccesorioData
    {
        public static List<ModeloAccesorio> ListaModeloAccesorio()
        {
            var db = new FamoxApiContext();
            return db.ModelosAccesorios.OrderBy(x => x.Id).ToList();
        }
        public static ModeloAccesorio ObtenerModeloAccesorio(int IdModeloAccesorio)
        {
            var db = new FamoxApiContext();
            return db.ModelosAccesorios.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdModeloAccesorio);
        }
        public static void CrearModeloAccesorio(ModeloAccesorio modeloAccesorio)
        {
            using (var context = new FamoxApiContext())
            {
                context.ModelosAccesorios.Add(modeloAccesorio);
                context.SaveChanges();
                context.SaveChanges();
            }
        }
        public static void ModificarModeloAccesorio(ModeloAccesorio modeloAccesorio)
        {
            using (var context = new FamoxApiContext())
            {
                var modeloAccesorioEditado = context.ModelosAccesorios.Where(x => x.Id.Equals(modeloAccesorio.Id)).Single();
                modeloAccesorioEditado.Nombre = modeloAccesorio.Nombre;
                modeloAccesorioEditado.Gases_ = modeloAccesorio.Gases_;
                modeloAccesorioEditado.Img = modeloAccesorio.Img;
                context.Entry(modeloAccesorioEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarModeloAccesorio(int IdModeloAccesorio)
        {
            using (var context = new FamoxApiContext())
            {
                var modeloAccesorio = context.ModelosAccesorios.Where(x => x.Id.Equals(IdModeloAccesorio)).Single();

                context.Remove(modeloAccesorio);
                context.SaveChanges();
            }
        }
    }
}
