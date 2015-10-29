using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task2_1.Enums;
using Task2_1.Interfaces;
using Task2_1.Model;

namespace Task2_1.Business.Workers
{
    public class WordWorker : IWordWorker
    {

        public int GetWordLength(ISentenceElement element)
        { 
            return element.Value.Length;
        }

        public bool FirstLetterIsConsonant(ISentenceElement element)
        {
            string pattern = @"[aeiou]";
            if (element.SentenceElementType == SentenceElementType.Word)
            {
                if (!string.IsNullOrEmpty(element.Value) && !(Regex.Matches(element.Value[0].ToString(), pattern).Count > 0))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public void ReplaceValue(int wordLenght, ISentenceElement element, string newValue)
        {
            if (element.SentenceElementType == SentenceElementType.Word && GetWordLength(element) == wordLenght)
            {
                element.Value = newValue;
            }
        }

    }
}
