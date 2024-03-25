using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiEntities
{
    public class EquipoDigital
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Uso { get; set; }
        public bool Anmat {  get; set; }
        public string Manual { get; set;}
        public string Img {  get; set; }
        public bool Modelos {  get; set; }

        /*public List<ModeloEquipoDigital> Modelos_ { get; set; }*/
        public string Descripcion {  get; set; }
        public int Codigo {  get; set; }
        public bool EquipoDigital_ {  get; set; }

    }
}
