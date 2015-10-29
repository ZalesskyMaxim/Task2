using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1.Enums;
using Task2_1.Interfaces;

namespace Task2_1.Model
{
    public class SentenceElement : ISentenceElement
    {
        public string Value { get; set; }
        public SentenceElementType SentenceElementType { get; private set; } 

        public SentenceElement(string sentenceElementValue, SentenceElementType type)
        {
            this.Value = sentenceElementValue;
            this.SentenceElementType = type;
        }

    }
}
