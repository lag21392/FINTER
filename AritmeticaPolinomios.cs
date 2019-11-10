using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINTER
{
    class AritmeticaPolinomios
    {
        public static double[] MultiplicarPolinomios(double[] polinomioA, double[] polinomioB)
        {
            var polinomioMultiplicacion = new double[polinomioA.Length + polinomioB.Length - 1];
            for (int i = 0; i < polinomioA.Length; i++)
            {
                for (int j = 0; j < polinomioB.Length; j++)
                {
                    polinomioMultiplicacion[i + j] += polinomioA[i] * polinomioB[j];
                }
            }
            return polinomioMultiplicacion;
        }

        public static double[] SumarPolinomios(double[] polinomioA, double[] polinomioB)
        {
            double[] polConMasElementos;
            double[] polConMenosElementos;
            double[] polinomioSuma;

            if (polinomioA.Length >= polinomioB.Length)
            {
                polConMasElementos = polinomioA;
                polConMenosElementos = polinomioB;

            }
            else
            {
                polConMasElementos = polinomioB;
                polConMenosElementos = polinomioA;
            }

            polinomioSuma = new double[polConMasElementos.Length];

            for (int i = 0; i < polConMasElementos.Length; i++)
            {
                if (i == polConMenosElementos.Length)
                {
                    //Ya no hay más elementos en el segundo vector. Se continúa poniendo elementos sólo del primero sin sumar.
                    polinomioSuma[i] = polConMasElementos[i];
                }
                else
                {
                    //Se suman los términos de cada vector para el grado correspondiente
                    polinomioSuma[i] = polConMasElementos[i] + polConMenosElementos[i];
                }
            }

            return polinomioSuma;

        }
    }
}
