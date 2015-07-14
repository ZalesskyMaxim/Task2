using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1.Business.Workers;
using Task2_1.Model;

namespace Task2_1
{
    public class Sentence
    {

        private readonly List<SentenceElement> sententenceElements;
        private static readonly WordWorker wordWorker = new WordWorker();
        public Sentence()
        {
            sententenceElements = new List<SentenceElement>();
        }

        public void AddElementToEnd(SentenceElement element)
        {
            sententenceElements.Add(element);
        }

        public int GetWordsCount()
        {
            int count = 0;
            foreach (var sentenceElement in sententenceElements)
            {
                if (sentenceElement.seType == SentenceElementType.Word)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetElementsCount()
        {
            return sententenceElements.Count;          
        }


        public SentenceElement GetElementByIndex(int index)
        {
            if (index < 0 || index >= sententenceElements.Count) return null;
            return sententenceElements[index];
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(sententenceElements[0].Value);
            for(int i = 1; i < sententenceElements.Count; i++)
            {
                if (sententenceElements[i].seType == SentenceElementType.Word)
                {
                    builder.Append(" ");
                }
                builder.Append(sententenceElements[i].Value);
            }
            return builder.ToString();
        }

        public void DeleteWords(int wordLenght)
        {
            for (int i = 0; i < sententenceElements.Count; i++ )
            {
                if (sententenceElements[i].seType == SentenceElementType.Word
                    && wordWorker.GetWordLenght(sententenceElements[i]) == wordLenght
                    && wordWorker.FirstLetterIsConsonant(sententenceElements[i]))
                {
                    sententenceElements.Remove(sententenceElements[i]);
                    i--;
                }
            }
        }

        public void ReplaceWords(int wordLenght, string newValue)
        {
            foreach (var currentSentence in sententenceElements)
            {
                wordWorker.ReplaceValue(wordLenght, currentSentence, newValue);
            }
        }
    }
}
