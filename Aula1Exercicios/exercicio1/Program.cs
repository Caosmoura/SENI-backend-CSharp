using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1;
            Console.WriteLine("Digite um número");
           
            float triplo;
            num1 = int.Parse(Console.ReadLine());

            triplo = (num1)*3 ;

            Console.WriteLine("o triplo é " + triplo);
            

            
        }
    }
}
