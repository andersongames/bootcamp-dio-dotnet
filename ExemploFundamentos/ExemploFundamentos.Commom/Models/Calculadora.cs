using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Commom.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro para somar</param>
        /// <param name="y">O segundo número inteiro para somar</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        /// <summary>
        /// Realiza uma subtração de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro para subtrair</param>
        /// <param name="y">O segundo número inteiro para subtrair</param>
        /// <returns>Retorna a subtração de x e y</returns>
        public int Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double res = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {res}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double res = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(res, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double res = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(res, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double res = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(res, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double res = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {Math.Round(res, 4)}");
        }
    }
}