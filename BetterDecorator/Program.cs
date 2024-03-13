using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor(string s, char dec, int num)
        {
            string resumo = ""; 
            for (int i = 0; i<num; i++)
            {
                resumo += $"{dec}";
            }
            resumo += $"{s}";

            for (int i = 0; i<num; i++)
            {
                resumo += $"{dec}";
            }
            return resumo;
        }
        static void Main(string[] args)
        
        {
            Console.WriteLine(Decor("Lost Forever", '.', 3 ));
            
        }
    }
}
