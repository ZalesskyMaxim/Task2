﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1.Business
{
    public interface IParser <T>
    {
        T Parse(List<string> str);
    }
}
