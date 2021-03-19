using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    class Alquiler
    {
        string carne;
        string libro;
        DateTime entrada;
        DateTime salida;

        public string Carne { get => carne; set => carne = value; }
        public string Libro { get => libro; set => libro = value; }
        public DateTime Entrada { get => entrada; set => entrada = value; }
        public DateTime Salida { get => salida; set => salida = value; }
    }
}
