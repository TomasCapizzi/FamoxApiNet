using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiEntities
{
    public class Gasoterapia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Uso { get; set; }
        public string Rango { get; set; }
        public bool Anmat { get; set; }
        public string Manual { get; set; }
        public string Img { get; set; }
        public bool Conexion { get; set; }
        public bool Gas { get; set; }
        public bool Modelos { get; set; }
        public List<Rango> Rangos { get; set; }
        public bool Gasoterapia_ {  get; set; }
        public List<string> Conectores { get; set; }
        public List<string> Gases_ {  get; set; }
        public int Orden {  get; set; }
        public List<ModeloGasoterapia> Modelos_ {  get; set; }


        public Gasoterapia() { }
    }
}
