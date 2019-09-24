using System;

namespace exer_5_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            double[] preco = new double[10];
            int[] estoque = new int[10];
            double total= 0;

            string sair = "";
            int cont=0;
            int quantidade_produto=0;

            while (sair != "0") {
                
                Console.WriteLine ("Bem vindo ao nosso sistema de passagem!");
                Console.WriteLine (
                    @"Menu :
                    1-Cadastrar
                    2-Listar produtos
                    3-Somar produtos
                    0-Sair");

                sair = Console.ReadLine ();


                switch(sair){
                    case "0": Console.WriteLine("saindo... :c");
                    break;
                    case"1":
                    while(cont <=9 ){
                    
                    Console.WriteLine("informe o nome do produto: ");
                    nome[cont]= Console.ReadLine();

                    
                    Console.WriteLine("informe o preço do produto: ");
                    preco[cont]= double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("informe o estoque do produto: ");
                    estoque[cont]= int.Parse(Console.ReadLine());
                    
                    quantidade_produto +=1;
                    
                    Console.WriteLine("Deseja cadastrar um novo produto (s/n)");
                    

                        string saida = Console.ReadLine();
                        if(saida=="n"|| saida=="N"){
                                break;
                        }
                        cont++;


                    }
                    break;

                    case"2":
                    if(nome[0]!= ""&&preco[0]!=0 && estoque[0]!=0){
                    for(int i=0; i<quantidade_produto; i++){
                        Console.WriteLine($"\nnome do produto: {nome[i]}\npreço do produto: {preco[i] } \n quantidade em estoque: {estoque[i]}\n");

                    }

                    }else{
                        Console.WriteLine("Não existe produto cadastrdo");
                    }


                    break;

                    case"3":
                     if(nome[0]!= ""&&preco[0]!=0 && estoque[0]!=0){
                    for(int i=0; i<quantidade_produto; i++){
                        total+= estoque[i]*preco[i];
                    }
                    Console.WriteLine("a soma de todos os produtos é: "+ total);

                    }else{
                        Console.WriteLine("Não existe produto cadastrdo");
                    }

                
                        
                    break;

                    default:
                    Console.WriteLine("opção inválida!");

                    break;
                }
            }
            


        }
    }
}
