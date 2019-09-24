using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            float salario, vendas, total;
            Console.WriteLine("Digite o seu salário");
            salario=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas");
            vendas=int.Parse(Console.ReadLine());
            total=salario+((vendas *0.05f));
            Console.WriteLine ("O resultado é "+total);
            


    
        }
    }
}
