using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float real ,dolar, total;
            Console.WriteLine("Digite o preço do real");
            real=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do dolar");
            dolar=int.Parse(Console.ReadLine());
            total = (real/dolar);
            Console.WriteLine ("O Valor da cotação é "+total);
        }
    }
}
