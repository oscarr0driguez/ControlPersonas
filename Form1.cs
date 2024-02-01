using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        // Clase objeto
        //Instanciar la clase
        //crear un objeto de esa clase
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            
            persona.Dpi = TxtDpi.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = TxtApe.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mostrar()
        {
            LblDpi.Text = persona.Dpi;
            LblNom.Text = persona.Nombre;
            LblApe.Text = persona.Apellido;
            LblFe.Text = persona.FechaNacimiento.ToShortDateString();
            LblEdad.Text = persona.edad().ToString();
            persona.normalizaNombre();

            LblDpi.Visible = true;
            LblNom.Visible = true;
            LblApe.Visible = true;
            LblFe.Visible = true;
            LblEdad.Visible = true;

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
            
        }

        private void BtnMayu_Click(object sender, EventArgs e)
        {
            persona.PrimeraMayus();
            LblNom.Text = persona.Nombre;
            LblApe.Text = persona.Apellido;
        }
    }
}
