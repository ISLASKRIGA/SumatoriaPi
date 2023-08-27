using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumatoriaPi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Pi mediante la sumatoria de Leibniz");

            int terminos = 1000000; // Cantidad de términos en la sumatoria
            double piAproximado = CalcularPiLeibniz(terminos);

            Console.WriteLine($"Valor aproximado de Pi: {piAproximado}");
        }

        static double CalcularPiLeibniz(int n)
        {
            double piAproximado = 0.0;

            for (int i = 0; i < n; i++)
            {
                double termino = 1.0 / (2 * i + 1);

                // Alternamos la suma entre positivo y negativo según el término
                if (i % 2 == 0)
                {
                    piAproximado += termino;
                }
                else
                {
                    piAproximado -= termino;
                }

            }

            // Multiplicamos por 4 para obtener una aproximación de Pi
            piAproximado *= 4;

            return piAproximado;

        }

    }

}
