using System;
using System.Globalization;
using System.Collections.Generic;


namespace FirstProject {
    class Program {
        static void Main(string[] args) {

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int linha = 0; linha < m; linha++) {
                string[] value = Console.ReadLine().Split(' ');
                for (int coluna = 0; coluna < n; coluna++) {
                    matriz[linha,coluna] = int.Parse(value[coluna]);
                }
            }
            for (int liha = 0; liha < m; liha++ ) {
                
                
                for (int coluna = 0; coluna < n; coluna++) {
                    if (matriz[liha,coluna] == 8) {
                        Console.WriteLine(liha + ", " + coluna);
                       
                    }
                    else if(liha <= 0) {
                        Console.WriteLine("Left: " + matriz[liha, coluna]);
                        
                    }
                   
                }
            }

        }

    }
}
