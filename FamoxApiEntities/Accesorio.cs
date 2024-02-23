using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiEntities
{
    public class Accesorio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Img {  get; set; }
        public List<ModeloAccesorio> Modelos { get; set; }
        public bool Accesorio_ {  get; set; }
        public string Manual { get; set; }
        public bool Gases {  get; set; }
        public bool AccesorioUS {  get; set; }

    }
}
