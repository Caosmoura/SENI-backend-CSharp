using System;

namespace aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deixamos declarada como falsa por padrão
           bool entrada = false;
           int idade;
           string retorno ;

           Console.WriteLine("Digite sua idade: ");
           idade = int.Parse(Console.ReadLine());

            //Como já atribuímos anteriormente,mudmos o estado da variável para verddeira caso entre nessa condiçõ
           if(idade >17){
               entrada = true;
           }
           if( entrada== true){
               retorno= "Entrada permitida!";
           }else{
               retorno = "Entrada não permitida :(";
           }
           Console.WriteLine(retorno);
        }
    }
}
