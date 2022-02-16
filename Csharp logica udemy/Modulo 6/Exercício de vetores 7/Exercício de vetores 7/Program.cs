using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, j = 0, c = 0;
            double maioralt, menoralt, mediamul = 0;
            string[] sexo;
            double[] altura;
            N = int.Parse(Console.ReadLine()); 
            sexo = new string[N];
           altura = new double[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0]);
                sexo[i] = s[1];
                if (sexo[i] == "M")
                {
                    j++;
                }
                else if (sexo[i] == "F") 
                { 
                    mediamul = mediamul + altura[i];
                    c++;
                }
            }
            maioralt = altura[0];
            menoralt = altura[0];
            for (int i = 0;i < N; i++)
            {
                if (maioralt < altura[i])
                {
                    maioralt = altura[i];
                }
            }
            for (int i = 0;i < N; i++)
            {
                if (menoralt > altura[i])
                {
                    menoralt = altura[i];
                }
            }
            mediamul = mediamul / c;
            Console.WriteLine("menor altura = " + menoralt);
            Console.WriteLine("maior altura = " + maioralt);
            Console.WriteLine("media da altura das mulheres = " + mediamul.ToString("F2"));
            Console.WriteLine("numero de homens = " + j);
            

        }
    }
}