using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    class libros
    {
        int codigo;
        string titulo;
        string autor;
        string publicacion;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Publicacion { get => publicacion; set => publicacion = value; }
    }
}
