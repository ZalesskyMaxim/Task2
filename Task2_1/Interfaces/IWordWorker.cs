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
        int GetWordLength(ISentenceElement element);
        bool FirstLetterIsConsonant(ISentenceElement element);
        void ReplaceValue(int wordLenght, ISentenceElement element, string newValue);
    }
}
