using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float produto, percentual, final;
            Console.WriteLine("Digite o preço do produto");
            produto=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual");
            percentual=int.Parse(Console.ReadLine());
            final=produto+((percentual/100)*produto);
            

        }
    }
}
