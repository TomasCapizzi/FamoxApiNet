using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiEntities
{
    public class Obra
    {
        public int Id { get; set; }
        public string Obra_ { get; set; }
        /*
        public List<string> Img { get; set; }
        public List<string> Instalacion { get; set; } */
        public string Img { get; set; }
        public string Instalacion { get; set; }
        public int Fecha { get; set; }  
    }
}
