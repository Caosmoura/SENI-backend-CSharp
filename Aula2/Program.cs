using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos as notas que usaremos
            double nota1, nota2, nota3, media;
            
            // Capturamos nota 1
            Console.Write("Digite sua primeira nota ");
            nota1 = double.Parse(Console.ReadLine());

            // Capturamos nota 2
            Console.Write("Digite sua segunda nota ");
            nota2 = double.Parse(Console.ReadLine());

            // Capturamos nota 3
            Console.Write("Digite sua terceira nota ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 / 3);

            //verificamos se a média do aluno é maior ou igual à 6
            if(media >= 6){
                
                Console.WriteLine($"media: {media} Aluno aprovao! ");
            
            }else{

                Console.WriteLine($"media: {media} Aluno reprovado ");
            }

        }
    }
}
