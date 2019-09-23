using System;

namespace exer_5_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            double[] preço = new double[10];
            int[] estoque = new int[10];
            double[] total = new double[10];

            string sair = "";
            int cont=0;

            while (sair != "0") {
                
                Console.WriteLine ("Bem vindo ao nosso sistema de passagem!");
                Console.WriteLine (
                    @"Menu :
                    1-Cadastrar
                    2-Listar passagens
                    3-Somar produtos
                    0-Sair");

                sair = Console.ReadLine ();

                switch(sair){
                    case"1":
                    while(cont <=9 ){
                    Console.WriteLine("informe o nome do produto: ");
                    nome[cont]= Console.ReadLine();
                    Console.WriteLine("informe o preço do produto: ");
                    preço[cont]= double.Parse(Console.ReadLine());
                    Console.WriteLine("informe o estoque do produto: ");
                    estoque[cont]= int.Parse(Console.ReadLine());
                        Console.WriteLine("Deseja cadastrar um novo produto (s/n)");
                        string saida = Console.ReadLine();
                        if(saida=="n"|| saida=="N"){
                                break;
                        }
                        cont++;


                    }
                    break;

                    case"2":

                    break;

                    case"3":

                    break;

                    case"4":

                    break;
                }
            }
            


        }
    }
}
