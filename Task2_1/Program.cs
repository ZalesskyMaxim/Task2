using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task2_1.Business;
using Task2_1.Business.Workers;
using Task2_1.Model;

namespace Task2_1
{
    class Program
    {
        static WordWorker wordWorker = new WordWorker();
        static void Main(string[] args)
        {
            IFileReader r = new Reader("input.txt");
            List<string> listSentences = new List<string>();
            IParser<Text> parser = new TextParser();
            listSentences = r.Read();
            var text = parser.Parse(listSentences);
            text.SortSentences();
            Console.WriteLine(text);
            Console.WriteLine("=======================");

            FindWordsOfPredeterminedLenght(text, 7);
            Console.WriteLine("=======================");

            text.RemoveWords(7);
            Console.WriteLine(text);
            Console.WriteLine("=======================");

            text.ReplaceWords(0, 5, "qq");
            Console.WriteLine(text);
            Console.WriteLine("=======================");

            Console.ReadKey();
        }

        public static void FindWordsOfPredeterminedLenght(Text text, int wordLenght)
        {
            List<string> words = new List<string>();
            foreach (var currentSentence in text.GetQuestionSentences())
            {
                for (int i = 0; i < currentSentence.GetWordsCount(); i++)
                {
                    var currentElement = currentSentence.GetElementByIndex(i);
                    if (currentElement.seType == SentenceElementType.Word 
                        && wordWorker.GetWordLenght(currentElement) == wordLenght)
                    {
                        var str = currentElement.Value.ToUpper();
                        if (!words.Contains(str))
                        {
                            words.Add(str);
                        }
                    }
                }
            }
            foreach (var result in words)
            {
                Console.WriteLine(result);
            }
        }

        


    }
}
