using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiEntities
{
    public class UnidadDeSuministro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Uso { get; set; }
        public bool Anmat { get; set; }
        public string Img { get; set; }
        public bool Conexion { get; set; }
        public bool Gas { get; set; }
        public bool Modelos { get; set; }
        public bool Gasoterapia { get; set; }
        public bool MediaTension { get; set; }
        public bool BajaTension { get; set; }
        public bool Conectores { get; set; }
        public bool Iluminacion { get; set; }
        public bool Gases { get; set; }
        /*
        public List<string> MediaTension { get; set; }
        public List<string> BajaTension { get; set; }
        public List<string> Conectores { get; set; }
        public List<string> Gases { get; set; }*/
        public int Orden { get; set; }
        public string Manual { get; set; }
        public bool Longitud { get; set; }
    }
}
