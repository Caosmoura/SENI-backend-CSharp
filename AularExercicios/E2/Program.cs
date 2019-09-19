using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
           float preço;
           
           Console.WriteLine("Digite o valor");
            preço = float.Parse(Console.ReadLine());


            if(preço>100){
                preço=preço -25;
                
            }
            
            Console.WriteLine(preço);
        }
    }
}
