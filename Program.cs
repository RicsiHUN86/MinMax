using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szamok = 10;
            int min = 1;
            int max = 100;

            Random random = new Random();
            int[] tomb = new int[szamok];

            for (int i = 0; i < szamok; i++)
            {
                tomb[i] = random.Next(min, max + 1);
            }

            int legkisebb = tomb[0];

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] < legkisebb)
                {
                    legkisebb = tomb[i];
                }
            }

            int legnagyobb = tomb[0];

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > legnagyobb)
                {
                    legnagyobb = tomb[i];
                }
            }

            Console.WriteLine("A tömbnek az elemei: " + string.Join(", ", tomb));
            Console.WriteLine("A legkisebb elem: " + legkisebb);
            Console.WriteLine("A legnagyobb elem: " + legnagyobb);
        }
    }
}
