using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1.Model
{
    public enum SentenceElementType { Word, PunctuationMark }
    public class SentenceElement
    {
        
        public string Value { get; set; }
        public SentenceElementType SEType { get; private set; } 

        public SentenceElement(string sentenceElementValue, SentenceElementType type)
        {
            this.Value = sentenceElementValue;
            this.SEType = type;
        }

    }
}
