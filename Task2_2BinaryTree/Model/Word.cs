using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task2_2BinaryTree
{
    public class Word //: IComparer
    {
        public string Value { get; private set; }
        public int WordCount { get; private set; }
        public static int LineNo { get; set; }
        public int LastLineNo { get; private set; }
        public HashSet<int> Lines = new HashSet<int>();

        public Word(string value)
        {
            this.Value = value;
        }


        public void UpdateWordCount()
        {
            WordCount++;
            if (WordCount == 1 || LastLineNo != LineNo)
            {
                Lines.Add(LineNo);
                LastLineNo = LineNo;
            }
        
        }

        public void AddLine(int iLine)
        {
            Lines.Add(iLine);
            WordCount++;
        }

        //public int Compare(object x, object y)
        //{
        //    Word wordX;
        //    Word wordY;
        //    if (x is Word)
        //    {
        //        wordX = (Word)x;
        //    }
        //    else { return 0; }
        //    if (y is Word)
        //    {
        //        wordY = (Word)y;
        //    }
        //    else { return 0; }
        //    return string.Compare(wordX.Value, wordY.Value);
        //}

        public override string ToString()
        {
            return String.Format("{0}............. {1}:  {2}", Value, WordCount, String.Join(" ", Lines));
        }

    }
}
