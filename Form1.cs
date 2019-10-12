using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FINTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Valor_K_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox_Valor_K_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void richTextBox_Lote_Datos_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloParentesisComasNumeros(e);
        }

        private void richTextBox_Lote_Datos_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloParentesisComasNumeros(e);
        }

        private void Button_HallarPolinomio_Click(object sender, EventArgs e)
        {
            string X = richTextBox_Lote_Datos_X.Text;
            string Y = richTextBox_Lote_Datos_Y.Text;
            //validacion de datos antes de hallar polinomio
            
            //Validar Formato datos X e Y
            if(!Validar.SoloFormatoDatos(X,"X") || !Validar.SoloFormatoDatos(Y, "Y"))
            {
                
            }else if(Regex.Replace(X,@"[0-9\-]", string.Empty) != Regex.Replace(Y,@"[0-9\-]", string.Empty)) {
                //Validar misma cantidad de numeros entre X e Y
                MessageBox.Show("No hay la misma cantidad de valores entre X y f(x)");
                
            }else if(radioButton_Lagrange.Checked.Equals(true))
            //Comprobar Tipo de resolucion a hallar
            {
                //Lagrange




            }
            else if (radioButton_NG_Progresivo.Checked.Equals(true))
            {
                //NG_progresivo





            }
            else if (radioButton_NG_Regresivo.Checked.Equals(true))
            {
                //NG_Regresivo





            }
            else
            {
                MessageBox.Show("No selecciono metodo de resolucion");
            }

        }

        private void Button_Resolver_Click(object sender, EventArgs e)
        {
            //comprovacion de si hay numero k
            if (textBox_Valor_K.Text.ToString() == "")
            {
                MessageBox.Show("Complete el valor K");
            }
            
        }
    }
}
