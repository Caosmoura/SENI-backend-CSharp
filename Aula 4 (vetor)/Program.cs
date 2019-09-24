using System;

namespace Aula_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valor = new double[10];
            for(int i=0; i<= 10; i++){

                Console.WriteLine("Digite uma média: ");
                valor[1] = double.Parse (Console.ReadLine());

            }
            Console.WriteLine(valor[3]);
            Console.WriteLine();

            for(int i=0; i<= valor.LongLength -1 ; i++){
                Console.WriteLine("Média : " + valor[i]);
               
            }
        }
    }
}
