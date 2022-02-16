using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {            
            int linha, coluna, N;
            double soma = 0;
            N = int.Parse(Console.ReadLine());
            double[,] matriz = new double[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
               // criar a matriz
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = double.Parse(s[j]);
                    if ( matriz[i, j] > 0)
                    {
                        soma = soma + matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("f1"));
            // encontrar a linha selecionada
            linha = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");           
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[linha, j].ToString("f1") + " ");
                }
            Console.WriteLine();
            // encontrar a coluna selecionada
            coluna = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0;i < N; i++)
            {
                Console.Write(matriz[i, coluna].ToString("f1") + " ");              
            }
            Console.WriteLine();
            // encontrar a diagonal principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i].ToString("f1") + " ");
            }
            Console.WriteLine();
            // matriz alterada
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0;i < N; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        matriz[i, j] = matriz[i, j] * matriz[i, j];
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j].ToString("f1") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}