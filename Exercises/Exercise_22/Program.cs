using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text: ");
            string text = Console.ReadLine();

            string filterText = FilterBadWord(text);
            Console.WriteLine(filterText);
            Console.ReadLine();
                  

        }
        static string FilterBadWord(string text)
        {
            text = text.ToLower();

            List<string> badWords = new List<string>();
            badWords.Add("fuck");
            badWords.Add("fag");
            badWords.Add("shit");
            badWords.Add("asshole");


            foreach (var badword in badWords)
            {
                if (text.Contains(badword))
                {
                    text = text.Replace(badword, "****");
                    text = text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();

                }


            }
            return text;

        }
    }
}
