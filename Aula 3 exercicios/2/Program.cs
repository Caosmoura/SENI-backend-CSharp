using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n;
            Console.WriteLine("Digite um numero");
            n=int.Parse(Console.ReadLine());
            for
            (int cont=1; cont <=10; cont++){
                Console.WriteLine($"{cont}*{n}={cont*n} ") ;


            }
    
        }
    }
}
