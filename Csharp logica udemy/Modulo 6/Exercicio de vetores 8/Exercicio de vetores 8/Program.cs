using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, j = 0, c = 0, z = 0;
            double lucro, totalC = 0, totalV = 0, LT;
            string[] Nome;
            double[] precovendas;
            double[] precocompras;
            N = int.Parse(Console.ReadLine());
            Nome = new string[N];
            precocompras = new double[N];
            precovendas = new double[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                Nome[i] = s[0];
                precocompras[i] = double.Parse(s[1]);
                precovendas[i] = double.Parse(s[2]);
                lucro = ((precovendas[i] * 100) / precocompras[i]) - 100;
                if (lucro < 10)
                {
                    j++;
                }
                else if (lucro >= 10 && lucro <= 20)
                {
                    c++;
                }
                else if (lucro > 20)
                {
                    z++;
                }
            }
            for (int i = 0;i < N; i++)
            {
                totalC = totalC + precocompras[i];
                totalV = totalV + precovendas[i];
            }
            LT = totalV - totalC;
            Console.WriteLine("Lucro abaixo 10%: " + j);
            Console.WriteLine("Lucro entre 10% e 20%: " + c);
            Console.WriteLine("Lucro acima de 20%: " + z);
            Console.WriteLine("Valor total de compra: " + totalC.ToString("F2"));
            Console.WriteLine("Valor total de venda: " + totalV.ToString("F2"));
            Console.WriteLine("Lucro total: " + LT.ToString("F2"));
        }
    }
}
