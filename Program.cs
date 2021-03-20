using System;
using System.Globalization;

namespace uri_1115
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos 
            // no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. 
            // O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA 
            // (nesta situação sem escrever mensagem alguma).

            // Entrada
            // A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.

            // Saída
            // Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a 
            // coordenada lida, conforme o exemplo.

            double x, y;

            

            do {

                string [] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);

                    if (x > 0.0 && y > 0.0) 
                {
                    System.Console.WriteLine("primeiro");
                } 
                else if (x < 0.0 && y > 0.0) 
                {
                    System.Console.WriteLine("segundo");
                } 
                else if (x < 0.0 && y < 0.0) 
                {
                    System.Console.WriteLine("terceiro");
                } 
                else if (x > 0.0 && y < 0.0) 
                {
                    System.Console.WriteLine("quarto");
                }            
            } 
            while (x != 0.0 && y != 0.0);            
        }
    }
}