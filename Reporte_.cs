using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    class Reporte_
    {
        string nombre;
        string titulo;
        DateTime prestamo;
        DateTime devolucion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime Prestamo { get => prestamo; set => prestamo = value; }
        public DateTime Devolucion { get => devolucion; set => devolucion = value; }
    }
}
