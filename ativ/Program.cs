using System;

namespace ativ
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_prod,resposta;
            int num,pessoa=0,total=50;
            
          Console.WriteLine("Gostaria de receber ou fornecer? ");
          resposta=Console.ReadLine();
          if(resposta=="receber"){
              Console.WriteLine("Digite o nome do produto: ");
              nome_prod=Console.ReadLine();
              Console.WriteLine("Quantidade do produto: ");
              num=int.Parse(Console.ReadLine());
              switch(nome_prod){
                  case "banana":
                  pessoa=pessoa+num;
                  total=total-num;
                  break;

                  case "pera":
                  pessoa=pessoa+num;
                  total=total-num;
                  break;

                  case "cenoura":
                  pessoa=pessoa+num;
                  total=total-num;
                  break;

                  case "abacate":
                  pessoa=pessoa+num;
                  total=total-num;
                  break;

                  case "rabanete":
                  pessoa=pessoa+num;
                  total=total-num;
                  break;

                  default:
                  Console.WriteLine("Erro, não possuimos esse produto!");
                  break;
                   
              }
              Console.WriteLine($"Você recebeu {num} de {nome_prod}");
              Console.WriteLine($"Total:{total}");
          }
              
          else{
            Console.WriteLine("Digite o nome do produto: ");
              nome_prod=Console.ReadLine();
              Console.WriteLine("Quantidade do produto: ");
              num=int.Parse(Console.ReadLine());
              switch(nome_prod){
                  case "banana":
                  total=total+num;
                  break;

                  case "pera":
                  total=total+num;
                  break;

                  case "cenoura":
                  total=total+num;
                  break;

                  case "abacate":
                  total=total+num;
                  break;

                  case "rabanete":
                  total=total+num;
                  break;

                  default:
                  Console.WriteLine("Erro, não possuimos esse produto!");  
                  break;   
                    }
                Console.WriteLine($"Estoque:{total}");
            
                }

        }   
    }
}