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
    public partial class Form1 : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();
        List<libros> Libros = new List<libros>();
        List<datos_estudiante> estudiantes = new List<datos_estudiante>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            FileStream stream = new FileStream(@"..\..\alquiler.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var alquiler in alquileres)
            {
                writer.WriteLine(alquiler.Carne);
                writer.WriteLine(alquiler.Libro);
                writer.WriteLine(alquiler.Entrada);
                writer.WriteLine(alquiler.Salida);
            }
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.Carne = textBoxCarne.Text;
            alquiler.Libro = textBoxCodigo.Text;
            alquiler.Entrada = dateTimePickerEntrada.Value;
            alquiler.Salida = dateTimePickerEntrada.Value;

            alquileres.Add(alquiler);
            Guardar();


        }
    }
}
