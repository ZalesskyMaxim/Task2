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
        static void Main(string[] args)
        {
            string line = "=============================================================";
            IFileReader r = new Reader("input.txt");
            List<string> listSentences = new List<string>();
            IParser<Text> parser = new TextParser();
            listSentences = r.Read();
            var text = parser.Parse(listSentences);

            ///1 Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них.
            foreach (var item in text.SortSentences())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(line);

            ///2 Во всех вопросительных предложениях текста найти и напечатать без повторений слова заданной длины.
            text.FindWordsOfPredeterminedLenght(text, 7);
            Console.WriteLine(line);

            ///3 Из текста удалить все слова заданной длины, начинающиеся на согласную букву.
            text.RemoveWords(7);
            Console.WriteLine(text);
            Console.WriteLine(line);

            ///4 В некотором предложении текста слова заданной длины заменить указанной подстрокой, 
            ///длина которой может не совпадать с длиной слова.
            text.ReplaceWords(0, 5, "Vasya");
            Console.WriteLine(text);
            Console.WriteLine(line);

            Console.ReadKey();
        }
    }
}
