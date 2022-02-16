using System;

namespace uri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0, y = 1, z = 2, mdx, mdy, mdz;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                if (i == 0)
                {
                    x++;
                    y++;
                    z++;
                    Console.Write(x);
                    Console.Write(" " + y);
                    Console.WriteLine(" " + z + " PUM");
                }
                else
                {
                    mdx = x + 4;
                    mdy = y + 4;
                    mdz = z + 4;
                    Console.Write(mdx);
                    Console.Write(" " + mdy);
                    Console.WriteLine(" " + mdz + " PUM");
                    x = x + 4;
                    y = y + 4;
                    z = z + 4;
                }
            }


            

        }
    }
}