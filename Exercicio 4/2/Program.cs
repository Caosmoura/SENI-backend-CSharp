using System;

namespace _2 {
    class Program {
        static void Main (string[] args) {
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] v3 = new int[20];

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite um valor");
                v1[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite um valor");
                v2[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 20; i++) {

                if (i < 10) {
                    v3[i] = v1[i];

                } else if (i > 9) {
                    v3[i] = v2[i - 10];

                }
                Console.WriteLine (v3[i]);
            }

        }

    }
}