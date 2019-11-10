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
        double[] vXAnt;
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
            FINTER.Validar.SoloParentesisComasNumeros(e);
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
            string[] listaDeValoresX = X.Split(',');
            string[] listaDeValoresY = Y.Split(',');
            //Validar Formato datos X e Y
            if (!Validar.SoloFormatoDatos(X, "X") || !Validar.SoloFormatoDatos(Y, "Y"))
            {

            } else if ( listaDeValoresX.Length != listaDeValoresY.Length) {
                //Validar misma cantidad de numeros entre X e Y
                MessageBox.Show("No hay la misma cantidad de valores entre X y f(x)");

            } else if (radioButton_Lagrange.Checked.Equals(true))
            //Comprobar Tipo de resolucion a hallar
            {
                //Lagrange
                //carga de datos vector vX y vY
                int cantidadValoresXeY = X.Split(',').Length;
                double[] vX = new double[cantidadValoresXeY];
                double[] vY = new double[cantidadValoresXeY];
                vXAnt = vX;
                richTextBox_Pasos_Calculo.Text = CargarVectoresXeY(X, Y, vX, vY) + "\n";
                VerfificaEquidistancia(vX);

                //carga de vector vL
                string[] vPL = new string[cantidadValoresXeY];
                double[] vL = new double[cantidadValoresXeY];
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
                    richTextBox_Pasos_Calculo.Text += "L" + i + "(x) = " + vPL[i] + "         ";
                    richTextBox_Pasos_Calculo.Text += "L" + i + "(" + vX[i] + ") = " + CalcularExprecion(vPL[i], vX[i], false);
                    richTextBox_Pasos_Calculo.Text += "\n\n";
                    if (CalcularExprecion(vPL[i], vX[i], false) == 0)
                    {

                    }
                    else if (polinomio == "")
                    {
                        polinomio += " (" + vY[i] + "/" + CalcularExprecion(vPL[i], vX[i], false) + ")*" + vPL[i];
                    }
                    else
                    {
                        polinomio += " + (" + vY[i] + "/" + CalcularExprecion(vPL[i], vX[i], false) + ")*" + vPL[i];
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
                richTextBoxPolinomioDistinto.Text = SeAlteroPolinomio(polinomioAnterior, polinomio, vXAnt,vX);


                richTextBox_PolinomioPdeX.Text = "L(x) = ";
                richTextBox_PolinomioPdeX.Text += polinomio.Replace("+-", "-");

                //Preguntar como sacar grado de polinomio de lagrange
                //richTextBoxGdeX.Text += "G(L(x)) = ";
                //richTextBoxGdeX.Text += G_de_Px.ToString();

            }
            else if (radioButton_NG_Progresivo.Checked.Equals(true))
            {
                //NG_progresivo
                //carga de datos vector vX y vY
                int cantidadValoresXeY = X.Split(',').Length;
                double[] vX = new double[cantidadValoresXeY];
                double[] vY = new double[cantidadValoresXeY];
                richTextBox_Pasos_Calculo.Text = CargarVectoresXeY(X, Y, vX, vY);
                VerfificaEquidistancia(vX);

                //carga de vector vO metodo general son los o1 o2 o3 etc
                //se crea y se genere tabla de vectores con su tamaño correspondiente a cada uno
                double[][] vO = new double[cantidadValoresXeY - 1][];
                for (int i = 0; i < cantidadValoresXeY - 1; i++)
                {
                    vO[i] = new double[cantidadValoresXeY - 1 - i];
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
                richTextBoxPolinomioDistinto.Text = SeAlteroPolinomio(polinomioAnterior, polinomio, vXAnt,vX);
                //Validacion de si hay polinomiodistinto


                richTextBox_PolinomioPdeX.Text = "P(x) = ";
                richTextBox_PolinomioPdeX.Text += polinomio.Replace("+-","-");

                //Calculo e impresion de grado de polinomio
                int G_de_Px = 0;
                for (int i = 0; i < vO.Length; i++)
                {
                    double sumadorColumna = 0;
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
                int cantidadValoresXeY = X.Split(',').Length;
                double[] vX = new double[cantidadValoresXeY];
                double[] vY = new double[cantidadValoresXeY];
                richTextBox_Pasos_Calculo.Text = CargarVectoresXeY(X, Y, vX, vY);
                VerfificaEquidistancia(vX);

                //carga de vector vO metodo general son los o1 o2 o3 etc
                //se crea y se genere tabla de vectores con su tamaño correspondiente a cada uno
                double[][] vO = new double[cantidadValoresXeY - 1][];
                for (int i = 0; i < cantidadValoresXeY - 1; i++)
                {
                    vO[i] = new double[cantidadValoresXeY - 1 - i];
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
                richTextBoxPolinomioDistinto.Text = SeAlteroPolinomio(polinomioAnterior, polinomio, vXAnt,vX);

                richTextBox_PolinomioPdeX.Text = "P(x) = ";
                richTextBox_PolinomioPdeX.Text += polinomio.Replace("+-", "-");

                //Calculo e impresion de grado de polinomio
                int G_de_Px = 0;
                for (int i = 0; i < vO.Length; i++)
                {
                    double sumadorColumna = 0;
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
        private void VerfificaEquidistancia(double[] vx)
        {
            int i = 0;
            double distancia;
            double distancia_proximo;
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
                textBox_P_de_K.Text = Convert.ToString(CalcularExprecion(richTextBox_PolinomioPdeX.Text.Replace("P(x) = ", "").Replace("L(x) = ", ""), Convert.ToDouble(textBox_Valor_K.Text.Replace(".", ",")),true));
            }

        }


        public static String CargarVectoresXeY(string X, string Y, double[] vX, double[] vY)
        {
            String consola = "| " +CentrarString("X",6)+ "  |  " + CentrarString("Y", 6) + "  | \n";
            int cantidadValoresXeY = X.Split(',').Length;
            //paso a formato de (1,3,8) a 1,3,8,
            string remplazoX = Regex.Replace(X, @"[()]", string.Empty) + ",";
            string remplazoY = Regex.Replace(Y, @"[()]", string.Empty) + ",";
            for (int i = 0; i < cantidadValoresXeY && remplazoX.Contains(","); i++)
            {

                string prueba = remplazoX.Substring(0, remplazoX.IndexOf(','));
                vX[i] = Convert.ToDouble(remplazoX.Substring(0, remplazoX.IndexOf(',')).Replace(".", ","));
                vY[i] = Convert.ToDouble(remplazoY.Substring(0, remplazoY.IndexOf(',')).Replace(".", ","));
                if (remplazoX.IndexOf(',') + 1 < remplazoX.Length)
                {
                    remplazoX = remplazoX.Substring(remplazoX.IndexOf(',') + 1, remplazoX.Length - remplazoX.IndexOf(',') - 1);
                    remplazoY = remplazoY.Substring(remplazoY.IndexOf(',') + 1, remplazoY.Length - remplazoY.IndexOf(',') - 1);

                }



                consola += " | " + CentrarString(vX[i].ToString(), 6);
                consola += " | ";
                consola += CentrarString(vY[i].ToString(), 6);
                consola +=  " | " + "\n";
            }
            return consola;
        }
        public  double CalcularExprecion(string expresion, double x,Boolean imprimir)
        {
            expresion = expresion.Replace(",", ".");
            if (imprimir == true) {
                richTextBox_Pasos_Calculo.Text += "\n\n";
                richTextBox_Pasos_Calculo.Text += "P(K) = " + expresion;
            }

            while (expresion.Contains("("))
            
            {
                    int IndexPrimerParentesisAbierto = expresion.IndexOf('(');
                    int IndexPrimerParentesisCerrado = expresion.IndexOf(')');
                    string exprecionInteraAResolver = expresion.Substring(IndexPrimerParentesisAbierto + 1, IndexPrimerParentesisCerrado- IndexPrimerParentesisAbierto-1);
                    

                    double fxInterna;
                    Calculo AnalizadorDeFuncionesInterna = new Calculo();

                    if (AnalizadorDeFuncionesInterna.Sintaxis(exprecionInteraAResolver, 'x'))
                    {
                    fxInterna = AnalizadorDeFuncionesInterna.EvaluaFx(x);
                    
                    expresion = expresion.Replace(expresion.Substring(IndexPrimerParentesisAbierto , IndexPrimerParentesisCerrado - IndexPrimerParentesisAbierto +1), Math.Round(fxInterna, 10).ToString()).Replace(",", ".");
                    
                    }
                    else
                    {
                        MessageBox.Show("Mal la sintaxis de la funcionInterna");
                        // aquí mensaje de error en sintaxis
                    }
            }
            
            if (imprimir == true)
            {
                richTextBox_Pasos_Calculo.Text += "\n\n";
                richTextBox_Pasos_Calculo.Text += "P(" + x.ToString() + ") = " + expresion;
            }
            double fx;
            Calculo AnalizadorDeFunciones = new Calculo();

            if (AnalizadorDeFunciones.Sintaxis(expresion, 'x'))
            {
                fx = AnalizadorDeFunciones.EvaluaFx(x);
               
                if (imprimir == true)
                {
                    richTextBox_Pasos_Calculo.Text += "\n\n";
                    richTextBox_Pasos_Calculo.Text += "P(" + x.ToString() + ") = " + Math.Round(fx, 10).ToString();
                }
                return Math.Round(fx, 10);
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
        private  String SeAlteroPolinomio(String polinomio1, String polinomio2, double[] vX1,double[] vX2)
        {
            if (polinomio1 == "")
            {
                return "";
            }
            for (int i = 0; i < vX1.Length; i++)
            {

                if (Math.Round(CalcularExprecion(polinomio1, vX1[i], false) - CalcularExprecion(polinomio2, vX1[i], false), 10) != 0.0000)
                {
                    return "SI";
                }
            }
            for (int i = 0; i < vX2.Length; i++) {

                if (Math.Round(CalcularExprecion(polinomio1, vX2[i],false) -CalcularExprecion(polinomio2, vX2[i],false),10)!=0.0000)
                {
                    return "SI";
                }
            }
                        for(int i = 0; i < vX2.Length; i++) {

                if (Math.Round(CalcularExprecion(polinomio1, vX2[i],false) -CalcularExprecion(polinomio2, vX2[i],false),10)!=0.0000)
                {
                    return "SI";
                }
            }
            return "NO";
        }

        private static String CentrarString(String texto, int tamanioLugar)
        {
            int dondeTieneQueEmpesarTexto = (tamanioLugar / 2) - (texto.Length / 2);
            int dondeTieneQueTerminarTexto = (tamanioLugar / 2) + (texto.Length / 2);
            String textoConEspacios = texto;
            return textoConEspacios.PadLeft(dondeTieneQueEmpesarTexto).PadRight(tamanioLugar-dondeTieneQueTerminarTexto);
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
