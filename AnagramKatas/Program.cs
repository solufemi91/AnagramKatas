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
            // find all the words that have the same length as wordToMatch
            // go through each letter of wordToMatch and put it into a groups
            // make note of the number each letter has
            // b x1
            // g x2
            // n x3
            // e x1
            // i x2
            // go through each word from the filtered list
            // for example, the word beginning
            // does the word have b x1? yes Go on to the next group
            // does it have g x2? if i get to the end of the word, it belongs to the anagram group
            // if it does not, go the next word in the list


            var wordToMatch = "beginning";//words[52];
            var wordToMatchAsEnumerable = wordToMatch.AsEnumerable();
            var groupOfLettersForWordToMatch = wordToMatchAsEnumerable.GroupBy(e => e.ToString());
            var filteredWords = words.Where(word => word.Length == wordToMatch.Length);
            filteredWords.ElementAt(62);

            // get the name of the first group
            // check that the other word has a group with the same name
            // if so compare the count
            // if its the same, move on to the next group

            //groupOfLettersForWordToMatch.ToList().ForEach(x => x.Key);
            foreach (var group in groupOfLettersForWordToMatch)
            {
                var test = group.Key;
                var trueFalse = filteredWords.ElementAt(62).GroupBy(e => e.ToString()).Any(x => x.Key == test);



            }

        }
    }
}
