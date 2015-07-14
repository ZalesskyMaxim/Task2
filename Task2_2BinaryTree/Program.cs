using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2BinaryTree.Parsers;
using Task2_2BinaryTree.Readers;

namespace Task2_2BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader newReader = new Reader("input.txt");
            BinaryTree<Word> tree = new BinaryTree<Word>();
            List<string> lines = new List<string>();
            lines = newReader.Read();
            IParser parser = new Parser();
            var words = parser.Parse(lines);
            foreach (var w in words.Values)
            {
                tree.Add(w);
            }

            Console.WriteLine(string.Join("\n", tree.Inorder()));
            Console.ReadKey();
        }
    }
}
