﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1.Business.Workers;
using Task2_1.Interfaces;

namespace Task2_1.Model
{
    public class Text
    {
        private List<ISentence> _sentences;
        private readonly IWordWorker _wordWorker;
        private readonly IPunctuationMarkWorker _punctuationMarkWorker;
        public Text()
        {
            _sentences = new List<ISentence>();
            _wordWorker = new WordWorker();
            _punctuationMarkWorker = new PunctuationMarkWorker();
        }

        public void AddSentence(Sentence sentence)
        {
            _sentences.Add(sentence);
        }

        public IEnumerable<ISentence> SortSentences()
        {
            return _sentences.OrderBy(x => x.GetWordsCount());
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _sentences);
        }

        public List<ISentence> GetQuestionSentences()
        {
            List<ISentence> questionSentences = new List<ISentence>();
            foreach (var currentSentence in _sentences)
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

        public List<ISentence> GetSentences()
        {
            return _sentences;
        }

        public void RemoveWords(int wordLenght)
        {
            foreach (var currentSentence in _sentences)
            {
                currentSentence.DeleteWords(wordLenght);
            }
        }

        public void ReplaceWords(int indexSentense, int wordLenght, string newValue)
        {
            var currentSentence = _sentences[indexSentense];
            if (currentSentence == null) return;
            currentSentence.ReplaceWords(wordLenght, newValue);
        }

        public void FindWordsOfPredeterminedLenght(Text text, int wordLenght)
        {
            List<string> words = new List<string>();
            foreach (var currentSentence in text.GetQuestionSentences())
            {
                for (int i = 0; i < currentSentence.GetWordsCount(); i++)
                {
                    var currentElement = currentSentence.GetElementByIndex(i);
                    if (currentElement.seType == SentenceElementType.Word
                        && _wordWorker.GetWordLength(currentElement) == wordLenght)
                    {
                        var str = currentElement.Value.ToUpper();
                        if (!words.Contains(str))
                        {
                            words.Add(str);
                        }
                    }
                }
            }
            foreach (var result in words)
            {
                Console.WriteLine(result);
            }
        }

    }
}
