using System;

namespace pattern_star2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=2; i++)
            {
                for (int j = i; j>=i; j--)
                {
                    Console.Write("@");
                }
             
                   
            }
             for (int i = 3;i>=1;i++)
            {
                for(int j=3;j>=i;j--)
                {
                    Console.Write("*");
                }
            }

        }
    }
}
