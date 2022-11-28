using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();
            Empleado.Comision = 72;
            MessageBox.Show("La comision es de "+Empleado.Comision.ToString());
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Empleado empleado3 = new Empleado();
            Empleado empleado4 = new Empleado();
            Empleado.Comision = 45;
            MessageBox.Show("La comision ahora es de " + Empleado.Comision.ToString());

        }
    }
}
