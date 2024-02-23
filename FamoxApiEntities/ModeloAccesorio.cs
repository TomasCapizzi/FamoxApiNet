using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiEntities
{
    public class ModeloAccesorio
    {
        public string Nombre { get; set; }
        public List<Gases> Gas { get; set; }
        public string Img {  get; set; }

    }
}
