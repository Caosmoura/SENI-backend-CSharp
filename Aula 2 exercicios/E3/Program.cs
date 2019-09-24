using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
           float valor1, valor2;
           Console.WriteLine("Digite o primeiro valor");
            valor1 = float.Parse(Console.ReadLine ());

             Console.WriteLine("Digite o segundo valor ");
            valor2 = float.Parse(Console.ReadLine ());
            
            if(valor1>valor2){
                Console.WriteLine(valor1);
            }
            else{
                Console.WriteLine(valor2); 
            }
        }
    }
}
