﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1.Enums;
using Task2_1.Interfaces;
using Task2_1.Model;

namespace Task2_1.Business.Workers
{
    public class PunctuationMarkWorker : IPunctuationMarkWorker
    {
        public bool IsQuestionMark(ISentenceElement element)
        {
            if (element.SentenceElementType == SentenceElementType.PunctuationMark)
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
