using System;
using System.Collections.Generic;
using System.Collections;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] main_sentence ={"the", "quick", "and" ,"brown" ,"fox" ,"jumps" ,"over" ,"the" ,"lazy" ,"dog"};
            Console.WriteLine("Enter the word:");
            string word = Console.ReadLine();
            List<int> codes = new List<int>();
            
            foreach(char c in word){
                 foreach(string x in main_sentence){
                    if (x.Contains(c))
                    {
                        int first=main_sentence.FindIndex(x);
                        int second=x.IndexOf(c);
                        
                        Console.WriteLine(first);
                        break;
                    }
                }
            }       
        }
    }
}
