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

using Calculus;

namespace FINTER
{
    public partial class Form1 : Form
    {
        string polinomio = "";
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
            if (!Validar.SoloFormatoDatos(X, "X") || !Validar.SoloFormatoDatos(Y, "Y"))
            {

            } else if (Regex.Replace(X, @"[0-9\-]", string.Empty) != Regex.Replace(Y, @"[0-9\-]", string.Empty)) {
                //Validar misma cantidad de numeros entre X e Y
                MessageBox.Show("No hay la misma cantidad de valores entre X y f(x)");

            } else if (radioButton_Lagrange.Checked.Equals(true))
            //Comprobar Tipo de resolucion a hallar
            {
                //Lagrange
                //carga de datos vector vX y vY
                int cantidadValoresXeY = Regex.Replace(X, @"[0-9\-]", string.Empty).Length - 1;
                int[] vX = new int[cantidadValoresXeY];
                int[] vY = new int[cantidadValoresXeY];
                richTextBox_Pasos_Calculo.Text = CargarVectoresXeY(X, Y, vX, vY) + "\n";
                VerfificaEquidistancia(vX);

                //carga de vector vL
                string[] vPL = new string[cantidadValoresXeY];
                int[] vL = new int[cantidadValoresXeY];
                polinomio = "";
                for (int i = 0; i < cantidadValoresXeY; i++)
                {
                    vPL[i] = "";
                    for (int j = 0; j < cantidadValoresXeY; j++)
                    {
                        if (j != i)
                        {
                            if (vPL[i] == "")
                            {
                                vPL[i] += "(x-" + vX[j].ToString() + ")";
                            }
                            else
                            {
                                vPL[i] += "*(x-" + vX[j].ToString() + ")";
                            }

                            vL[i] = vL[i] * (vX[i] - vX[j]);
                        }

                    }
                    richTextBox_Pasos_Calculo.Text += "L" + i + "(x) = " + vPL[i] + "    ";
                    richTextBox_Pasos_Calculo.Text += "L" + i + "(" + vX[i] + ") = " + CalcularExprecion(vPL[i], vX[i]);
                    richTextBox_Pasos_Calculo.Text += "\n\n";
                    if (CalcularExprecion(vPL[i], vX[i]) == 0)
                    {

                    }
                    else if (polinomio == "")
                    {
                        polinomio += " (" + vY[i] + "/" + CalcularExprecion(vPL[i], vX[i]) + ")*" + vPL[i];
                    }
                    else
                    {
                        polinomio += " + (" + vY[i] + "/" + CalcularExprecion(vPL[i], vX[i]) + ")*" + vPL[i];
                    }

                }

                //Validacion de si hay polinomiodistinto
                if (richTextBox_PolinomioPdeX.Text != "L(x) = " + polinomio)
                {
                    richTextBoxPolinomioDistinto.Text = "SI";
                }
                else
                {
                    richTextBoxPolinomioDistinto.Text = "NO";
                }

                //Comparamos polinomio anterior con el nuevo
                String polinomioAnterior = richTextBox_PolinomioPdeX.Text.Replace("P(x) = ", "").Replace("L(x) = ", "");
                richTextBoxPolinomioDistinto.Text = SeAlteroPolinomio(polinomioAnterior, polinomio, vX);


                richTextBox_PolinomioPdeX.Text = "L(x) = ";
                richTextBox_PolinomioPdeX.Text += polinomio;

                //Preguntar como sacar grado de polinomio de lagrange
                //richTextBoxGdeX.Text += "G(L(x)) = ";
                //richTextBoxGdeX.Text += G_de_Px.ToString();

            }
            else if (radioButton_NG_Progresivo.Checked.Equals(true))
            {

                //NG_progresivo
                //carga de datos vector vX y vY
                int cantidadValoresXeY = Regex.Replace(X, @"[0-9\-]", string.Empty).Length - 1;
                int[] vX = new int[cantidadValoresXeY];
                int[] vY = new int[cantidadValoresXeY];
                richTextBox_Pasos_Calculo.Text = CargarVectoresXeY(X, Y, vX, vY);
                VerfificaEquidistancia(vX);

                //carga de vector vO metodo general son los o1 o2 o3 etc
                //se crea y se genere tabla de vectores con su tamaño correspondiente a cada uno
                int[][] vO = new int[cantidadValoresXeY - 1][];
                for (int i = 0; i < cantidadValoresXeY - 1; i++)
                {
                    vO[i] = new int[cantidadValoresXeY - 1 - i];
                    for (int j = 0; j < vO[i].Length; j++)
                    {
                        if (i == 0)
                        {
                            if ((vX[j + 1] - vX[j]) != 0)
                            {
                                vO[i][j] = (vY[j + 1] - vY[j]) / (vX[j + 1] - vX[j]);
                            }
                            else
                            {
                                MessageBox.Show("vO[" + i + "][" + j + "] Es = 0 ya que divicion por 0");
                                vO[i][j] = 0;
                            }

                        }
                        else
                        {
                            if ((vX[j + (vX.Length - vO[i].Length)] - vX[j]) != 0)
                            {
                                vO[i][j] = (vO[i - 1][j + 1] - vO[i - 1][j]) / (vX[j + (vX.Length - vO[i].Length)] - vX[j]);
                            }
                            else
                            {
                                MessageBox.Show("vO[" + i + "][" + j + "] Es = 0 ya que divicion por 0");
                                vO[i][j] = 0;
                            }
                        }

                    }
                }
                string polinomio = "";
                polinomio += vY[0].ToString();
                for (int i = 0; i < vO.Length; i++)
                {
                    if (vO[i][0] != 0)
                    {
                        polinomio += "+" + vO[i][0].ToString();
                        for (int x = 0; x <= i; x++)
                        {
                            polinomio += "*(x-" + vX[x].ToString() + ")";
                        }
                    }

                }

                //mostrar vectores O
                richTextBox_Pasos_Calculo.Text += "\n Vectores O: ";

                for (int i = 0; i < vO.Length; i++)
                {
                    richTextBox_Pasos_Calculo.Text += "\n | o" + i.ToString() + " | ";
                    for (int j = 0; j < vO[i].Length; j++)
                    {

                        richTextBox_Pasos_Calculo.Text += vO[i][j].ToString() + " | ";


                    }
                }
                //Comparamos polinomio anterior con el nuevo
                String polinomioAnterior = richTextBox_PolinomioPdeX.Text.Replace("P(x) = ", "").Replace("L(x) = ", "");
                richTextBoxPolinomioDistinto.Text = SeAlteroPolinomio(polinomioAnterior, polinomio, vX);
                //Validacion de si hay polinomiodistinto


                richTextBox_PolinomioPdeX.Text = "P(x) = ";
                richTextBox_PolinomioPdeX.Text += polinomio;

                //Calculo e impresion de grado de polinomio
                int G_de_Px = 0;
                for (int i = 0; i < vO.Length; i++)
                {
                    int sumadorColumna = 0;
                    for (int j = 0; j < vO[i].Length; j++)
                    {
                        sumadorColumna += vO[i][j];
                    }
                    if (sumadorColumna == 0)
                    {

                        i = vO.Length;
                    }
                    else
                    {
                        G_de_Px++;
                    }
                }
                richTextBoxGdeX.Text = "G(P(x)) = ";
                richTextBoxGdeX.Text += G_de_Px.ToString();
            }
            else if (radioButton_NG_Regresivo.Checked.Equals(true))
            {
                //NG_Regresivo
                //carga de datos vector vX y vY
                int cantidadValoresXeY = Regex.Replace(X, @"[0-9\-]", string.Empty).Length - 1;
                int[] vX = new int[cantidadValoresXeY];
                int[] vY = new int[cantidadValoresXeY];
                richTextBox_Pasos_Calculo.Text = CargarVectoresXeY(X, Y, vX, vY);
                VerfificaEquidistancia(vX);

                //carga de vector vO metodo general son los o1 o2 o3 etc
                //se crea y se genere tabla de vectores con su tamaño correspondiente a cada uno
                int[][] vO = new int[cantidadValoresXeY - 1][];
                for (int i = 0; i < cantidadValoresXeY - 1; i++)
                {
                    vO[i] = new int[cantidadValoresXeY - 1 - i];
                    for (int j = 0; j < vO[i].Length; j++)
                    {
                        if (i == 0)
                        {
                            if ((vX[j + 1] - vX[j]) != 0) {
                                vO[i][j] = (vY[j + 1] - vY[j]) / (vX[j + 1] - vX[j]);
                            }
                            else
                            {
                                MessageBox.Show("vO[" + i + "][" + j + "] Es = 0 ya que divicion por 0");
                                vO[i][j] = 0;
                            }
                        }
                        else
                        {
                            if ((vX[j + (vX.Length - vO[i].Length)] - vX[j]) != 0)
                            {
                                vO[i][j] = (vO[i - 1][j + 1] - vO[i - 1][j]) / (vX[j + (vX.Length - vO[i].Length)] - vX[j]);
                            }
                            else
                            {
                                MessageBox.Show("vO[" + i + "][" + j + "] Es = 0 ya que divicion por 0");
                                vO[i][j] = 0;
                            }
                        }

                    }
                }
                string polinomio = "";
                polinomio += vY[vY.Length - 1].ToString();
                for (int i = 0; i < vO.Length; i++)
                {
                    if (vO[i][vO[i].Length - 1] != 0)
                    {
                        polinomio += "+" + vO[i][vO[i].Length - 1].ToString();
                        for (int x = 0; x <= i; x++)
                        {
                            polinomio += "*(x-" + vX[vX.Length - 1 - x].ToString() + ")";
                        }
                    }

                }

                //mostrar vectores O
                richTextBox_Pasos_Calculo.Text += "\n Vectores O: ";

                for (int i = 0; i < vO.Length; i++)
                {
                    richTextBox_Pasos_Calculo.Text += "\n | o" + i.ToString() + " | ";
                    for (int j = 0; j < vO[i].Length; j++)
                    {

                        richTextBox_Pasos_Calculo.Text += vO[i][j].ToString() + " | ";


                    }
                }

                //Comparamos polinomio anterior con el nuevo
                String polinomioAnterior = richTextBox_PolinomioPdeX.Text.Replace("P(x) = ", "").Replace("L(x) = ", "");
                richTextBoxPolinomioDistinto.Text = SeAlteroPolinomio(polinomioAnterior, polinomio, vX);

                richTextBox_PolinomioPdeX.Text = "P(x) = ";
                richTextBox_PolinomioPdeX.Text += polinomio;

                //Calculo e impresion de grado de polinomio
                int G_de_Px = 0;
                for (int i = 0; i < vO.Length; i++)
                {
                    int sumadorColumna = 0;
                    for (int j = 0; j < vO[i].Length; j++)
                    {
                        sumadorColumna += vO[i][j];
                    }
                    if (sumadorColumna == 0)
                    {

                        i = vO.Length;
                    } else {
                        G_de_Px++;
                    }
                }
                
                richTextBoxGdeX.Text = "G(P(x)) = ";
                richTextBoxGdeX.Text += G_de_Px.ToString();


            }
            else
            {
                MessageBox.Show("No selecciono metodo de resolucion");
            }
        }
        private void VerfificaEquidistancia(int[] vx)
        {
            int i = 0;
            int distancia;
            int distancia_proximo;
            distancia = vx[i + 1] - vx[i];
            
           // distancia_proximo = distancia;
            do {
                distancia_proximo = vx[i + 1] - vx[i];
                i++;
            }
            while (distancia.Equals(distancia_proximo) && i<vx.Length-1);
            if (distancia==distancia_proximo)
            {
                label6.Visible = true;
                richTextBoxEquidistanteTexto.Visible = true;
                richTextBoxEquidistanteTexto.Text ="SI";
                
            }
            else
            {
                label6.Visible = true;
                richTextBoxEquidistanteTexto.Visible = true;
                richTextBoxEquidistanteTexto.Text ="NO";
            }
        }
        private void Button_Resolver_Click(object sender, EventArgs e)
        {
            //comprovacion de si hay numero k
            if (textBox_Valor_K.Text.ToString() == "")
            {
                MessageBox.Show("Complete el valor K");
            }
            else
            {
                textBox_P_de_K.Text = Convert.ToString(CalcularExprecion(richTextBox_PolinomioPdeX.Text.Replace("P(x) = ", "").Replace("L(x) = ", ""), Convert.ToInt32(textBox_Valor_K.Text)));
            }

        }


        public static String CargarVectoresXeY(string X, string Y, int[] vX, int[] vY)
        {
            String consola = "|  X  |  Y  | \n";
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
        public static double CalcularExprecion(string expression, int x)
        {
            double fx;
            Calculo AnalizadorDeFunciones = new Calculo();

            if (AnalizadorDeFunciones.Sintaxis(expression, 'x'))
            {
                fx = AnalizadorDeFunciones.EvaluaFx(x);

                return fx;
            }
            else
            {
                MessageBox.Show("Mal la sintaxis de la funcion");
                // aquí mensaje de error en sintaxis
            }
            return -1;
        }

        private void finalizar() {
            Close();
        }
        private static String SeAlteroPolinomio(String polinomio1, String polinomio2,int[] vX)
        {
            for(int i = 0; i < vX.Length; i++) {
                if (CalcularExprecion(polinomio1, vX[i]) != CalcularExprecion(polinomio2, vX[i]))
                {
                    return "SI";
                }
            }
            return "NO";
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox_PolinomioPdeX_TextChanged(object sender, EventArgs e)
        {

        }

        private void finalizar(object sender, EventArgs e)
        {
            finalizar();
        }

        private void EquidistanteTexto_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
