using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, vendas, total;
            string Seunome;
            Console.WriteLine ("informe seu nome ");
            Seunome = Console.ReadLine();
            
            
             Console.WriteLine("Digite o seu salario fixo");
             salario = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o total de vendas");
            vendas = int.Parse(Console.ReadLine());
    
            total =salario + (vendas*0.10f);
            Console.WriteLine ("O seu nome é "+Seunome);
            Console.WriteLine ("O Valor de seu salario é "+salario);
            Console.WriteLine ("O Valor total no fim do mês é "+total);
           
            


        }
    }
}
