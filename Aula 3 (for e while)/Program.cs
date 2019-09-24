using System;

namespace Aula_3 {
    class Program {
        static void Main (string[] args) {

            //Laço contado - For - incremento (+)
            for (int cont1 = 1; cont <= 100; cont++) {

                //Verificamos se o número é diferente de par
                if (cont1 % 2 != 0) {
                    Console.WriteLine ("FOR 0-100 - " + cont1);
                }
            }

            for (int cont2 = 100; cont >= 0; cont--) {
                if (cont2 % 2 != 0) {
                    Console.WriteLine ("FOR 100-0 - "+ cont2);

                }
            }

            // Laço condicional - While
            
            double acumuladora = 0;
            double nota        = 0;
            int cont           = 0;
            string sair       = "";
            
            while( sair != "sim"){
                

                Console.WriteLine("Digite a nota de um aluno");
                nota = double.Parse(Console.ReadLine());

                acumuladora +=nota;
                cont ++;

                Console.WriteLine("Deseja sair da aplicação? sim/não");
                sair = Console.ReadLine().ToLower();

            }
            Console.WriteLine("média das notas:"+(acumuladora/cont));

          
            





        }
    }

}