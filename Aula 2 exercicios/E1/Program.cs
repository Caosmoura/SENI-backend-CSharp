using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, despesa;
            string  total;
          

            Console.WriteLine("Digite seu salario");
            salario = float.Parse(Console.ReadLine () );

             Console.WriteLine("Digite sua despesa");
            despesa = float.Parse(Console.ReadLine ());

            if( salario > despesa){
                total = "Superávit";
            }else{
                total = "Défcit";
            }
            Console.WriteLine($"total: {total} -Você está {total}");
        }
    }
}
