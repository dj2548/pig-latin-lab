using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;

namespace piggy_latin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            while (word == string.Empty)
            {
                Console.WriteLine("Enter a word or phrase please.");
                word = Console.ReadLine();
            }

            string[] words = word.Split(' ');
            //string[] currWord = words[0].Split(' ');
            string vowelWordEnd = "way";
            string conWordEnd = "ay";
            char letter;
            int vowelPosition = -1;
            string newSentence = "";
            foreach (string currWord in words) 
            {
                string currWordLower = currWord.ToLower();
                if ((currWordLower[0] == 'a' || currWordLower[0] == 'e' || currWordLower[0] == 'i' || currWordLower[0] == 'o' || currWordLower[0] == 'u')) 
                 {
                    newSentence += currWord + vowelWordEnd + " ";
                } else 
                {
                    newSentence += currWord + " ";
                }
                   

               
            }
            Console.WriteLine(newSentence);
        }
    }
}


