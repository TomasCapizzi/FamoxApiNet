using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiEntities
{
    public class ModeloEquipoDigital
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Uso { get; set; }
        public string Origen { get; set; }
        public string Img { get; set; }
        public List<string> Modulos { get; set; }
        public string Codigo { get; set; }


    }
}
