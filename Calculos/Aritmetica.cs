using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Aritmetica
    {
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>
        public int Somar(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Operação subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números.</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operação de multiplicação.
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x, int y) 
        {
            return x * y;
        }
    }
}