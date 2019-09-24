using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[]v1 = new string[15];
            string[]v2 = new string[15];
            string[]v3 = new string[30];

            for(int i=0; i<=14; i++){
                Console.WriteLine("Digite um filme");
                v1[i]=Console.ReadLine();
            }
            for(int i=0; i<=14; i++){
                Console.WriteLine("Digite um filme");
                v2[i]=Console.ReadLine();
            }
            for(int i=0; i<=30; i++){

                 if(i<15){
                   v3[i]=v1[i];

                }
                else if(i>14){
                    v3[i]=v2[i-15];

                }
                Console.WriteLine(v3[i]);


                
             }
        }
    }
}
