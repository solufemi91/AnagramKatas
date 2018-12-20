using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramKatas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintOutAnagramMatches();
        }

        public static void PrintOutAnagramMatches()
        {
            string[] words = System.IO.File.ReadAllLines(@"C:\Users\HP\source\repos\AnagramKatas\Anagram.txt");
            
            var wordToMatch = "listen";//words[52];
            var wordToMatchAsEnumerable = wordToMatch.AsEnumerable();
            var groupOfLettersForWordToMatch = wordToMatchAsEnumerable.GroupBy(e => e.ToString());
            var filteredWords = words.Where(word => word.Length == wordToMatch.Length);

            bool match = true;
            
            foreach (var group in groupOfLettersForWordToMatch)
            {

                try
                {
                    var matchingGroup = "silent".GroupBy(e => e.ToString()).First(x => x.Key == group.Key && x.Count() == group.Count());
                }
                catch(InvalidOperationException)
                {
                    match = false;
                    break;
                }

                
               
            }

            if (match)
            {
                Console.WriteLine("IS AN ANAGRAM");
            }
            else
            {
                Console.WriteLine("NOT AN ANAGRAM");
            }
            





        }
    }
}
