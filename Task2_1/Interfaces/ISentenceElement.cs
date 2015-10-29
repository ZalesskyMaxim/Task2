﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1.Enums;
using Task2_1.Model;

namespace Task2_1.Interfaces
{
    public interface ISentenceElement
    {
        string Value { get; set; }
        SentenceElementType SentenceElementType { get; }
    }
}
