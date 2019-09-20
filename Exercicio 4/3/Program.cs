using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]produto = new string [12];
            string[]cor = new string [12];
            string[]tamanho = new string [12];
            double[]preco = new double [12];

            for(int i=0; i<=11; i++){
                Console.WriteLine("Digite o produto");
                produto[i]=Console.ReadLine();

            }
            for(int i=0; i<=11; i++){
                Console.WriteLine("Digite a cor");
                cor[i]=Console.ReadLine();

            }
            for(int i=0; i<=11; i++){
                Console.WriteLine("Digite o tamanho");
                tamanho[i]=Console.ReadLine();

            }for(int i=0; i<=11; i++){
                Console.WriteLine("Digite o preço");
                preco[i]=double.Parse(Console.ReadLine());

            }
            
            
        }
    }
}
