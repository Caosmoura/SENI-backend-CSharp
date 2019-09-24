using System;

namespace _1
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            
            double[] n = new double[10];
            
            for(int i=0; i<=9; i++){
                Console.WriteLine("digite sua nota");
                n[i]=double.Parse(Console.ReadLine());
             
               
                

            }

            Console.WriteLine(n[9]*5);
            
            
            
            
            
            
        }
    }
}
