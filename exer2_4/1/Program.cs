using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lanche; 
            string resultado;

             Console.WriteLine("Digite o número do pedido ");
             lanche = int.Parse(Console.ReadLine());


             switch(lanche){
                
                case 1:
                resultado = "Switch - Hamburguer";
                break;

                case 2:
                resultado = "Switch - Cheese Salada";
                break;

                case 3:
                resultado = "Switch - Cheese Burguer";
                break;

                case 4:
                resultado = "Switch - Cheese bacon";
                break;

                default:
                resultado="Switch - Pedido invalido!";
                break;



             }
             Console.WriteLine(resultado);

            
             

            

        }
    }
}
