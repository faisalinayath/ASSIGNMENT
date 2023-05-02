using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] main_sentence = { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
            Console.WriteLine("Enter the word:");
            string word = Console.ReadLine();
            List<int> codes = new List<int>();

            foreach (char c in word)
            {
                for (int i = 0; i < main_sentence.Length; i++)
                {
                    if (main_sentence[i].Contains(c))
                    {

                        int wordIndex = i + 1;
                        int letterIndex = main_sentence[i].IndexOf(c);

                        string first = wordIndex.ToString();
                        string second = letterIndex.ToString();

                        string final = first + second;
                        int new_final = Convert.ToInt32(final);

                        codes.Add(new_final);
                        break;

                    }
                }
            }



            string concat = string.Join(",", codes.ToArray());



            Console.WriteLine(concat);

        }
    }
}
