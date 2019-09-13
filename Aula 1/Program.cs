using System;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)

        {
            //Somente declaramos, sem atribuir valor
            int num1;

            // Declaramos atribuindo valor
            int num2 = 5;

            //Declaramos diversas vriáveis do mesmo tipo
            int num3, num4, num5;

            //Variável do tipo decimal (real)
            float media;
            
            //Variável do tipo lógico
            bool resultado = false;

            //Variável do tipo texto (caracteres)
            string nomeAluno;
            
            //Quebra linha
            Console.WriteLine();

            //Escreve em uma linha quebrando-a
            Console.WriteLine("Bem vindos a nossa primeira aplicação");
            
            //Continua escrevendo na mesma linha mostra na tela
            Console.Write("Digite");
            Console.Write("Seu nome: ");

            //Capturo o dado digitado pelo usúario e salvo na variável pega o dado
            nomeAluno = Console.ReadLine();

            //Concatenação
            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota:");

            //Converto o texto capturado para o tipo inteiro
            num3 = int.Parse(Console.ReadLine());
            
            //Interpulação
            Console.WriteLine($"Sua primeira nota é {num3} ");

            Console.WriteLine("Digite sua segunda nota");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota");
            num5 = int.Parse(Console.ReadLine());

            media = (num3 + num4 + num5)/3;

            Console.WriteLine("sua media é" + media);

            

        }

    }
}
