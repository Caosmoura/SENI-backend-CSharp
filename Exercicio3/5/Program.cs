using System;

namespace _5 {
    class Program {
        static void Main (string[] args) {
            double salario = 0;
            int cont = 0;
            string sair = "";
            double acumuladora = 0;

            while( sair != "sim"){
                Console.WriteLine ("Digite o salario de um funcionario salario");
                salario = double.Parse (Console.ReadLine ());

                acumuladora += salario;
                cont++;

                Console.WriteLine ("Deseja sair da aplicação? sim/não");
                sair = Console.ReadLine ().ToLower ();

            }
            Console.WriteLine("a média dos salarios é "+(acumuladora/cont));
            Console.WriteLine("O total de pessoas é "+cont);
        }
    }

}