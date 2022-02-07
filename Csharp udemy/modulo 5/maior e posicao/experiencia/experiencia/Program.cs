using System;

namespace primeiro
{

    class program
    {
        static void Main(string[] args)
        {
            double n, x, Total = 0, totalc = 0, totals = 0, totalr = 0;
            double pr, pc, ps;
            string option;
            n = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {                
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0]);
                option = vet[1];

                if (option.Equals("c")) 
                {
                    totalc += x;
                    
                }
            else if (option.Equals("s"))
                {
                    totals += x;
                }
                else if (option.Equals("r"))
                {
                    totalr += x;
                }
                

            }
            Total = totalr + totals + totalc;
            pr = (totalr / Total) * 100;
            ps = (totals / Total) * 100;
            pc = (totalc / Total) * 100;

            Console.WriteLine("total: " + Total + " cobaias");
            Console.WriteLine("total coelhos: " + totalc);
            Console.WriteLine("total de ratos: " + totalr);
            Console.WriteLine("total de sapos: " + totals);
            Console.WriteLine("percentual de coelhos: " + pc.ToString("f2") + "%");
            Console.WriteLine("percentual de ratos: " + pr.ToString("f2") + "%");
            Console.WriteLine("percentual de sapos: " + ps.ToString("f2") + "%");

        }
    }
}