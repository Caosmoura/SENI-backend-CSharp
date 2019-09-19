using System;

namespace Aula_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
           double acumuladora =0;
           int cont = 1;
           int n;

           do{
               Console.WriteLine("Digite um número");
                n=int.Parse(Console.ReadLine());
               
               if (n %3 == 0){
                   acumuladora+=n;
                   
                }
                cont++;

           }while(cont<=20);

           Console.WriteLine(acumuladora);
        }
    }
}
