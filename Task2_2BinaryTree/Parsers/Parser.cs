using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2_2BinaryTree.Parsers
{
    public class Parser : IParser
    {
        public Dictionary<string, Word> Parse(List<string> text)
        {
            var res = new Dictionary<string, Word>();
            var iLine = 0;
            Word word;
            foreach (var line in text)
            {
                iLine++;
                foreach (Match match in Regex.Matches(line, @"\w+"))
                {
                    var wordKey = match.Value;

                    if (!res.TryGetValue(wordKey, out word))
                        word = res[wordKey] = new Word(wordKey);
                    word.AddLine(iLine);
                }
            }
            return res;
        }
    }
}
