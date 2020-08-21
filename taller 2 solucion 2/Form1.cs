using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_2_solucion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, nota5, promedio;

            nota1 = double.Parse(txtNota1.Text);

            nota2 = double.Parse(txtNota2.Text);

            nota3 = double.Parse(txtNota3.Text);


            nota4 = double.Parse(txtNota4.Text);

            nota5 = double.Parse(txtNota5.Text);

            promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            lblpromedio.Text = Convert.ToString(promedio);
            



            if (promedio >= 0 && promedio < 1)
            {
                lblmensaje.Text = "reprueba la materia sin lograr realisar proceso de recuperacion ";
            }

            else if (promedio >= 1.1 && promedio < 2.9)
            {

                lblmensaje.Text = "reprueba la materia y puede hacer habilitacion ";
               
            }

            else if (promedio >= 3 && promedio < 3.9) 
            {
                lblmensaje.Text = "aprueba la materia con plan de mejora";
            }

            else if (promedio >= 4 && promedio < 4.5) 
            {
                lblmensaje.Text = "buen rendimiento";
            }
            else if (promedio >= 4.6 && promedio < 4.9) 
            {
                lblmensaje.Text = "exelente";
            }

            else if (promedio == 5) 
            {
                lblmensaje.Text = "se gradua con honores";
            }
            

           lblpromedio.Visible = true;


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lblpromedio.Text = String.Empty;
            lblpromedio.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
