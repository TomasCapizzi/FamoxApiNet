using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class GasoterapiaData
    {
        public static List<Gasoterapia> ListaGasoterapia()
        {
            var db = new FamoxApiContext();
            return db.Gasoterapias.OrderBy(x => x.Id).ToList();
        }
        public static Gasoterapia ObtenerGasoterapia(int IdGasoterapia)
        {
            var db = new FamoxApiContext();
            return db.Gasoterapias.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdGasoterapia);
        }
        public static void CrearGasoterapia(Gasoterapia gasoterapia)
        {
            using (var context = new FamoxApiContext())
            {
                context.Gasoterapias.Add(gasoterapia);
                context.SaveChanges();
            }
        }
        public static void ModificarGasoterapia(Gasoterapia gasoterapia)
        {
            using (var context = new FamoxApiContext())
            {
                var gasoterapiaEditado = context.Gasoterapias.Where(x => x.Id.Equals(gasoterapia.Id)).Single();
                gasoterapiaEditado.Nombre = gasoterapia.Nombre;
                gasoterapiaEditado.Uso = gasoterapia.Uso;
                gasoterapiaEditado.Rango = gasoterapia.Rango;
                gasoterapiaEditado.Anmat = gasoterapia.Anmat;
                gasoterapiaEditado.Manual = gasoterapia.Manual;
                gasoterapiaEditado.Img = gasoterapia.Img;
                gasoterapiaEditado.Conexion = gasoterapia.Conexion;
                gasoterapiaEditado.Gas = gasoterapia.Gas;
                gasoterapiaEditado.Modelos = gasoterapia.Modelos;
                gasoterapiaEditado.Gasoterapia_ = gasoterapia.Gasoterapia_;
                gasoterapiaEditado.Conectores = gasoterapia.Conectores;
                gasoterapiaEditado.Gases_ = gasoterapia.Gases_;
                gasoterapiaEditado.Orden = gasoterapia.Orden;
                gasoterapiaEditado.Rangos = gasoterapia.Rangos;

                context.Entry(gasoterapiaEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarGasoterapia(int IdGasoterapia)
        {
            using (var context = new FamoxApiContext())
            {
                var gasoterapia = context.Gasoterapias.Where(x => x.Id.Equals(IdGasoterapia)).Single();

                context.Remove(gasoterapia);
                context.SaveChanges();
            }
        }
    }
}
