using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial
{
    public partial class Reporte : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();
        List<libros> Libros = new List<libros>();
        List<datos_estudiante> estudiantes = new List<datos_estudiante>();
        List<Reporte> reportes = new List<Reporte>();
      

        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

            if (File.Exists(@"..\..\libros.txt"))
            {
                FileStream stream = new FileStream(@"..\..\libros.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    libros libro = new libros();
                    Libros.Add(libro);

                }
                reader.Close();
            }
            if (File.Exists(@"..\..\estudiantes.txt")) 
            {
                FileStream stream = new FileStream(@"..\..\estudiantes.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1) 
                {
                    datos_estudiante estudiante = new datos_estudiante();
                    estudiantes.Add(estudiante);
                }
                reader.Close();
            }

            if (File.Exists(@"..\..\alquiler.txt"))
            {
                FileStream stream = new FileStream(@"..\..\alquiler.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Alquiler alquiler = new Alquiler();
                    alquileres.Add(alquiler) ;
                }
                reader.Close();
            }
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {
            foreach (var alquiler in alquileres)
            {
                datos_estudiante estudiante = estudiantes.Find(c=> c.Carne == alquiler.Carne);
                libros libro = Libros.Find(l => l.Titulo == alquiler.Libro);
                Reporte reporte = new Reporte();
                

                /*reporte.Nombre = estudiante.Nombre;
                reporte.Titulo = libro.Titulo;
                reporte.Prestamo = alquiler.Salida;
                reporte.Devolucion = alquiler.Entrada;
                */reportes.Add(reporte);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();
        }
    }
}
