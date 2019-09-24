using System;
using System.Globalization;
namespace Aula2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos as variáveis 
            float nota1, nota2, nota3, media;
            string resultado;
            
            Console.WriteLine("Digite a primeira nota");
            nota1 = float.Parse(Console.ReadLine (), CultureInfo.InvariantCulture );

             Console.WriteLine("Digite a segunda nota");
            nota2 = float.Parse(Console.ReadLine() );

             Console.WriteLine("Digite a terceira nota");
            nota3 = float.Parse(Console.ReadLine() );

            media = (nota1 + nota2 + nota3) / 3;

            if (media >=6){
                resultado = "Aprovado";
            }else if(media < 6 && media >=4){
                resultado = "Recuperação";
            }else {
                resultado = "reprovado";
            }
            Console.WriteLine($"Media: {media.ToString("F2")} -Aluno está {resultado}");






            
        }
    }
}
