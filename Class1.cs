// The text “the quick and brown fox jumps over the lazy dog” contains all the 26 alphabets in English. 
//We can generate a code for any letter in the following manner: 
//The code is a combination two digits. The first digit represents the index of the word (first occurrence), which contains the letter and the second digit represents the index of that letter in the found word. 
//For example, the letter “m” is found in the word “jumps” which is at index 5 in the sentence and in that word, “m” is found at index 2. Hence the code is 52. Similarly, the letter “v” is found in the word “over” which is at index 6 in the sentence and in that word, “v” is at index 

using System;
using System.Collections;
using System.Collections.Generic;

namespace project
{
    class data
    {
        public string sentence = "the quick and brown fox jumps over the lazy dog";
    }

    class hack
    {
        public static void Main(string[] args)
        {
            List<int> lst = new List<int>();

            Console.WriteLine("Enter The Word");
            string word = Console.ReadLine();

            foreach (var i in word)
            {
                data dataObj = new data();
                string main_sentence = dataObj.sentence;

                foreach (var z in main_sentence)
                {
                    string y = z.ToString();
                    string x = i.ToString();
                    if (y.Contains(x))
                    {
                        int first = main_sentence.IndexOf(y);
                        int second = y.IndexOf(x);

                        string first_new = first.ToString();
                        string second_new = second.ToString();

                        string final = string.Concat(first_new, second_new);

                        int final_int = Convert.ToInt32(final);

                        lst.Add(final_int);

                        break;
                    }
                }


            }

            foreach (var x in lst)
            {
                Console.WriteLine(x);
            }
        }
    }
}
