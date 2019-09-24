using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            float preço ;
            
            Console.WriteLine("Digite o preço");
            preço = float.Parse(Console.ReadLine());
            if(preço >=100 && preço<=1000){
                preço = preço *0.85f;

            }
            Console.WriteLine(preço);

            
                


            
            
        }
    }
}
