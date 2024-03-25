using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class EquipoDigitalData
    {
        public static List<EquipoDigital> ListaEquiposDigitales()
        {
            var db = new FamoxApiContext();
            return db.EquiposDigitales.OrderBy(x => x.Id).ToList();
        }
        public static EquipoDigital ObtenerEquipoDigital(int IdEquipoDigital)
        {
            var db = new FamoxApiContext();
            return db.EquiposDigitales.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdEquipoDigital);
        }
        public static void CrearEquipoDigital(EquipoDigital equipoDigital)
        {
            using (var context = new FamoxApiContext())
            {
                context.EquiposDigitales.Add(equipoDigital);
                context.SaveChanges();
            }
        }
        public static void ModificarEquipoDigital(EquipoDigital equipoDigital)
        {
            using (var context = new FamoxApiContext())
            {
                var equipoDigitalEditado = context.EquiposDigitales.Where(x => x.Id.Equals(equipoDigital.Id)).Single();
                equipoDigitalEditado.Nombre = equipoDigital.Nombre;
                equipoDigitalEditado.Anmat = equipoDigital.Anmat;
                equipoDigitalEditado.Manual = equipoDigital.Manual;
                equipoDigitalEditado.Img = equipoDigital.Img;
                equipoDigitalEditado.Modelos = equipoDigital.Modelos;
                equipoDigitalEditado.Descripcion = equipoDigital.Descripcion;
                equipoDigitalEditado.EquipoDigital_ = equipoDigital.EquipoDigital_;
                equipoDigitalEditado.Codigo = equipoDigital.Codigo;
                equipoDigitalEditado.Uso = equipoDigital.Uso;
                context.Entry(equipoDigitalEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarEquipoDigital(int IdEquipoDigital)
        {
            using (var context = new FamoxApiContext())
            {
                var accesorio = context.EquiposDigitales.Where(x => x.Id.Equals(IdEquipoDigital)).Single();

                context.Remove(accesorio);
                context.SaveChanges();
            }
        }
    }
}
