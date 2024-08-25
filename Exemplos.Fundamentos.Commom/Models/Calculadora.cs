using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Fundamentos.Commom.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x +y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {   
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {   
            double radiano = angulo * Math.PI;
            double sen = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(sen, 4)}");
        }

        public void Conseno(double angulo)
        {   
            double radiano = angulo * Math.PI;
            double cos = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(cos, 4)}");
        }

        public void Tangente(double angulo)
        {   
            double radiano = angulo * Math.PI;
            double tan = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(tan, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}