using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task2_1.Model;

namespace Task2_1.Business.Workers
{
    public class WordWorker
    {

        public int GetWordLenght(SentenceElement element)
        { 
            return element.Value.Length;
        }

        public bool FirstLetterIsConsonant(SentenceElement element)
        {
            string pattern = @"[aeiou]";
            if (element.seType == SentenceElementType.Word)
            {
                if (!string.IsNullOrEmpty(element.Value) && !(Regex.Matches(element.Value[0].ToString(), pattern).Count > 0))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public void ReplaceValue(int wordLenght, SentenceElement element, string newValue)
        {
            if (element.seType == SentenceElementType.Word && GetWordLenght(element) == wordLenght)
            {
                element.Value = newValue;
            }
        }

    }
}
