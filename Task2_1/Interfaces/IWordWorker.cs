using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1.Model;

namespace Task2_1.Interfaces
{
    public interface IWordWorker
    {
        int GetWordLength(SentenceElement element);
        bool FirstLetterIsConsonant(SentenceElement element);
        void ReplaceValue(int wordLenght, SentenceElement element, string newValue);
    }
}
