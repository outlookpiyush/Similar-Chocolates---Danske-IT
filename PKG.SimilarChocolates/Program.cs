using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKG.SimilarChocolates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input denoting the total number of elements in the array");
            int arrayElement = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[arrayElement];
            for(int i=0;i<number.Length;i++)
            {
                Console.WriteLine($"Input Array Element of {i}");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Output Is");
            Console.WriteLine(DivisorsNumber(number));

            Console.ReadLine();
        }
        static string DivisorsNumber(int[] n)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i=0;i<n.Length;i++)
            {
                for (int j = 1; j <= n[i]; j++)
                {
                    if (n[i] % j == 0)
                    {
                        if (dictionary.ContainsKey(j))
                            dictionary[j] = (int)dictionary[j] + 1;
                        else
                            dictionary.Add(j, 1);
                    }
                }
                    
            }
            var list = dictionary.Keys.ToList().Take(1);
            return string.Join(" ", list);
        }

    }


}
