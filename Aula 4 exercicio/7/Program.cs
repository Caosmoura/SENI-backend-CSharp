using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] n  = new double [10];
            double c=0;
            double indice =0;

            for(int i=0; i<=9; i++){
                
                Console.WriteLine("digite um número");
                n[i]=double.Parse(Console.ReadLine());

                if(c<n[i]){
                    indice = i;
                    c=n[i];

                }
                
                
            }
            
            Console.WriteLine (c+ " É o maior numero, indice " + indice );
                
            
        }
    }
}
