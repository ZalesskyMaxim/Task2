using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2BinaryTree.Parsers
{
    public interface IParser
    {
        Dictionary<string, Word> Parse(List<string> text);
    }
}
