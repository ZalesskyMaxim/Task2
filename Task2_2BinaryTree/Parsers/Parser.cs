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
            foreach (var line in text)
            {
                iLine++;
                foreach (Match m in Regex.Matches(line, @"\w+"))
                {
                    var word = m.Value;
                    Word w;
                    if (!res.TryGetValue(word, out w))
                        w = res[word] = new Word(word);
                    w.AddLine(iLine);
                }
            }

            return res;
        }
    }
}
