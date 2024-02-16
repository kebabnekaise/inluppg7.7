using System;

namespace inluppg7_x
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "a", "b", "b", "c", "hej" };
            string[] array2 = { "hej", "a", "a", "b", "programmering" };

            foreach (string s in FinnsIBada(array1, array2))
            {
                Console.WriteLine(s);
            }
        }

        static string[] FinnsIBada(string[] array1, string[] array2)
        {
            Dictionary<string, int> repeterade =  new Dictionary<string, int>();
            foreach (string s in array1)
            {
                repeterade[s] = 1;
            }

            int repeteradeAntal = 0;
            foreach (string s in array2)
            {
                if (repeterade.ContainsKey(s))
                {
                    repeterade[s]++;
                    repeteradeAntal++;
                }
            }
            string[] returnArray = new string[repeteradeAntal];

            int count = 0;
            foreach(string s in repeterade.Keys)
            {
                if (repeterade[s] >= 2)
                {
                    returnArray[count] = s;
                    count++;

                }
            }

            return returnArray;
        }
    }
}