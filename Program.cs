using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-- Média --");
            Console.ResetColor();

            Console.WriteLine("Digite as suas notas abaixo.");

            Console.Write("Nota 1: ");
            double um = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            double dois = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            double tres = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            double quatro = Convert.ToDouble(Console.ReadLine());

            double media = (um + dois + tres + quatro) / 4; 
            
            if (um > 10.0 || dois > 10.0 || tres > 10.0 || quatro > 10.0)
            {
                Console.WriteLine("Por favor, digite somente notas entre 0 e 10.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine($"Você ficou com média {media}. Resultado: Reprovado");
            }
            else if (media >= 6.0)
            {
                Console.WriteLine($"Você ficou com média {media}. Resultado: Aprovado");
            }
            else if (media >= 5.0 && media <=6.0) 
            {
                Console.WriteLine($"Você ficou com média {media}. Resultado: Em recuperação");
            }


            

            
            
            
            
            






        }
    }
}
