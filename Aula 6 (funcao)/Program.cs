using System;

namespace Aula_6__funcao_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamamos nossa primieira função
            Console.WriteLine(Bomdia("Boa tarde"));

            //Chamamos a função do tipo VOID que é sem retonto
            ImprimeDataHora();

            //Chamamos nossa função que calcula média
            double[] numero = {2 , 5 , 2 , 8 , 9 , 5};
            Console.WriteLine(CalculaMedia(numero));

            double[] vetores = {2, 5, 6};
            Console.WriteLine(SomaVetores(vetores));

        }

        /// <summary>
        /// Retorna um número - Teste de Sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <returns>Número passado como parametro</returns>

        static int Bomdia (int numero){
            return numero;
        }

        /// <summary>
        /// Função que escreve bom dia para o úsuario
        /// </summary>
        /// <returns>Retorna ola! Bom Dia</returns>
        

        static string Bomdia(){
            return "Olá Bom dia";
            
        }
        /// <summary>
        /// Funçao que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao"> um texto qualquer (sobrecarga de método)</param>
        /// <returns>Saudação de acordo com o horário</returns>

        static string Bomdia(string saudacao){
            
            int hora= DateTime.Now.Hour;

            if(hora <=12 && hora >=6){
                saudacao="Bom dia";
            
            }else if(hora>12 && hora<=18){
                saudacao = "Boa tarde";
            }else{
                saudacao="Boa noite";
            }
            return saudacao;
        }

        /// <summary>
        /// Retorna data e hora atuais
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour.ToString());

        }

        
        /// <summary>
        /// Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia(double[] valores){

            double resultado=0;

            for(int i=0; i < valores.Length ; i++ ){
                resultado = resultado + valores[i];
            }

            resultado= resultado / valores.Length;

            return resultado;

        }

        /// <summary>
        /// Calcula a soma de um vetor
        /// </summary>
        /// <param name="vetores">Vetor de doubles</param>
        /// <returns>A soma de valores</returns>
        static double SomaVetores (double [] vetores){

            double Soma=0;

            for(int i=0; i < vetores.Length; i++){
                Soma=Soma+vetores[i];

            }
            

            return Soma;
        }
    }
}
