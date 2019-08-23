using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double C = double.Parse(Console.ReadLine());

            // Processamento e saída
            if (a == 0)
            {
                Console.Write("O valor de A não pode ser 0");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            double delta = b*b - 4 * a * C;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta < 0)
            {
                Console.WriteLine("\nO delta é menor que 0, não há raízes reais.");
            }
            else if (delta == 0)
            {
                Console.WriteLine("\nDelta igual a 0, as raízes são iguais");
                Console.WriteLine("\nX1 = " + x1 + "\nX2 = " + x2);
            }
            else
            {
                Console.WriteLine("\nX1 = " + x1 + "\nX2 = " + x2);
            }

            Console.Write("\nPressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
