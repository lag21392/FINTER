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
            richTextBox_Pasos_Calculo.Text = "";
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
                //carga de datos vector vX y vY
                int cantidadValoresXeY = Regex.Replace(X, @"[0-9\-]", string.Empty).Length - 1;
                int[] vX = new int[cantidadValoresXeY];
                int[] vY = new int[cantidadValoresXeY];
                richTextBox_Pasos_Calculo.Text= CargarVectoresXeY(X, Y, vX, vY);
                



            }
            else if (radioButton_NG_Progresivo.Checked.Equals(true))
            {
                //NG_progresivo
                //carga de datos vector vX y vY
                int cantidadValoresXeY = Regex.Replace(X, @"[0-9\-]", string.Empty).Length - 1;
                int[] vX = new int[cantidadValoresXeY];
                int[] vY = new int[cantidadValoresXeY];
                richTextBox_Pasos_Calculo.Text = CargarVectoresXeY(X, Y, vX, vY);




            }
            else if (radioButton_NG_Regresivo.Checked.Equals(true))
            {
                //NG_Regresivo
                //carga de datos vector vX y vY
                int cantidadValoresXeY = Regex.Replace(X, @"[0-9\-]", string.Empty).Length - 1;
                int[] vX = new int[cantidadValoresXeY];
                int[] vY = new int[cantidadValoresXeY];
                richTextBox_Pasos_Calculo.Text = CargarVectoresXeY(X, Y, vX, vY);




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


        public static String CargarVectoresXeY(string X, string Y, int[] vX, int[] vY)
        {
            String consola="";
            int cantidadValoresXeY = Regex.Replace(X, @"[0-9\-]", string.Empty).Length - 1;
            //paso a formato de (1,3,8) a 1,3,8,
            string remplazoX = Regex.Replace(X, @"[()]", string.Empty) + ",";
            string remplazoY = Regex.Replace(Y, @"[()]", string.Empty) + ",";
            for (int i = 0; i < cantidadValoresXeY && remplazoX.Contains(","); i++)
            {

                string prueba = remplazoX.Substring(0, remplazoX.IndexOf(','));
                vX[i] = Convert.ToInt32(remplazoX.Substring(0, remplazoX.IndexOf(',')));
                vY[i] = Convert.ToInt32(remplazoY.Substring(0, remplazoY.IndexOf(',')));
                if (remplazoX.IndexOf(',') + 1 < remplazoX.Length)
                {
                    remplazoX = remplazoX.Substring(remplazoX.IndexOf(',') + 1, remplazoX.Length - remplazoX.IndexOf(',') - 1);
                    remplazoY = remplazoY.Substring(remplazoY.IndexOf(',') + 1, remplazoY.Length - remplazoY.IndexOf(',') - 1);

                }



               consola += " | " + vX[i].ToString() + " | " + vY[i].ToString() + " | " + "\n";
            }
            return consola;
        }
    }
}
