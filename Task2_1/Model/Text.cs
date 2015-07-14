using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1.Business.Workers;

namespace Task2_1.Model
{
    public class Text
    {
        private List<Sentence> sentences;
        private readonly WordWorker _wordWorker = new WordWorker();
        private readonly PunctuationMarkWorker _punctuationMarkWorker = new PunctuationMarkWorker();
        public Text()
        {
            sentences = new List<Sentence>();
        }

        public void AddSentence(Sentence sentence)
        {
            sentences.Add(sentence);
        }

        public void SortSentences()
        {
            sentences = sentences.OrderBy(x => x.GetWordsCount()).ToList();
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, sentences);
        }

        public List<Sentence> GetQuestionSentences()
        {
            List<Sentence> questionSentences = new List<Sentence>();
            foreach(var currentSentence in sentences)
            {
                var count = currentSentence.GetElementsCount();
                var currentElement = currentSentence.GetElementByIndex(count - 1);
                if (currentElement == null) continue;
                if (_punctuationMarkWorker.IsQuestionMark(currentElement))
                {
                    questionSentences.Add(currentSentence);
                }
            }
            return questionSentences;
            
        }

        public List<Sentence> GetSentences()
        {
            return sentences;
        }

        public void RemoveWords(int wordLenght)
        {
            foreach (var currentSentence in sentences)
            {
                currentSentence.DeleteWords(wordLenght);
            }
        }

        public void ReplaceWords(int indexSentense, int wordLenght, string newValue)
        {
            var currentSentence = sentences[indexSentense];
            if (currentSentence == null) return;
            currentSentence.ReplaceWords(wordLenght, newValue);
        }

    }
}
