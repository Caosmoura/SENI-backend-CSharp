using System;

namespace _5
{
    class Program
    {
        private const int V = 5;

        static void Main(string[] args)
        {
            double [] n  = new double [10];
           

            for(int i=0; i<=9; i++){
                
                Console.WriteLine("digite um número");
                n[i]=double.Parse(Console.ReadLine());
                
                
            }for(int i=0; i<=9; i++){
                Console.WriteLine(n[i]*2);

            }
            
            
            

        }
    }
}
