using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2BinaryTree.Readers;

namespace Task2_2BinaryTree
{
    public class Reader : IReader
    {
        private string fileName;
        private string bufLine = string.Empty;

        public Reader(string fName)
        {
            this.fileName = fName;
        }

        public List<string> Read()
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream, Encoding.Default);
            List<string> result = new List<string>();

            string str = string.Empty;
            while (!reader.EndOfStream)
            {
                str = reader.ReadLine();
                result.Add(str.ToLower());
            }
            reader.Close();
            return result;
        }
    }
}
