using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
           int  planeta;
           float peso_planeta, peso;

            Console.WriteLine("Digite o seu peso");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do planeta");
            planeta = int.Parse(Console.ReadLine());

            switch(planeta){
                
                case 1 :
                peso_planeta = (peso/10)* 0.37f;
                break;

                case 2:
                peso_planeta = (peso/10)* 0.88f;
                break;

                case 3:
                peso_planeta = (peso/10)* 0.38f;
                break;

                case 4:
                peso_planeta = (peso/10)* 2.64f;
                break;

                case 5:
                peso_planeta = (peso/10)* 1.15f;
                break;

                case 6:
                peso_planeta = (peso/10)* 1.17f;
                break;

                default:
                peso_planeta = peso;
                break;

                
            }
            Console.WriteLine(("seu peso no planeta é ")+peso_planeta);






        }
    }
}
