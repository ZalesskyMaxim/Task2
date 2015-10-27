﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1.Interfaces;
using Task2_1.Model;

namespace Task2_1.Business.Workers
{
    public class PunctuationMarkWorker : IPunctuationMarkWorker
    {
        public bool IsQuestionMark(SentenceElement element)
        {
            if (element.SEType == SentenceElementType.PunctuationMark)
            {
                if (element.Value.Equals("?"))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
