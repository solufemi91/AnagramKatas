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
            var words = System.IO.File.ReadAllLines(@"C:\Users\Steven.Olufemi-Oluka\source\repos\AnagramKatas\Anagram.txt")
                .Select(x => x.Trim());

            // the word that the program aims to find all the anagrams for
            var wordToMatch = words.First(x => x.ToString() == "crepitus").AsEnumerable();
            // array containing anagram set
            string[] arrayOfAnagramSet = new string[100];
            // the count of each differnt type of letter in the wordToMatch
            var letterGroups = wordToMatch.GroupBy(e => e.ToString());

            bool match = true;
            int i = 0;

            foreach (var word in words.Where(word => word.Length == wordToMatch.ToString().Length)) {

                foreach (var letterGroup in letterGroups)
                {

                    try
                    {
                        var matchingGroup = word.GroupBy(e => e.ToString())
                            .First(x => x.Key == letterGroup.Key && x.Count() == letterGroup.Count());
                        match = true;
                        
                        
                    }
                    catch (InvalidOperationException)
                    {
                        match = false;
                        break;
                    }

                }

                if (match)
                {
                    i++;
                    arrayOfAnagramSet[i] = word;
                }
           

            }

            foreach (var word in arrayOfAnagramSet)
            {
                Console.Write(" " +word);
            }

        }
    }
}
