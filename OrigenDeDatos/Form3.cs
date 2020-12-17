using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrigenDeDatos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = textBox1.Text;
            var contra = Seguridad.Encriptar(textBox2.Text);
            var mensaje = Funciones.insertar(usuario, contra);
            MessageBox.Show(mensaje);
        }
    }
}
