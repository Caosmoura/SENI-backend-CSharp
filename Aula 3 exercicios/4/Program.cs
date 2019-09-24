using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            int acumuladora=0;
            int quantidade_n=0;
            double media;
            
            
            for(int cont=1; cont <=5; cont++){
                Console.WriteLine("Digite um numero ");
                n=int.Parse(Console.ReadLine());
                if(n>0){
                    Console.WriteLine("positivo "+n);
                }                
                else{
                    acumuladora+=n;
                    quantidade_n +=1;

                }
                


            }
            media=(acumuladora/quantidade_n)*-1;
            Console.WriteLine("a média é "+media);
        }
    }
}
