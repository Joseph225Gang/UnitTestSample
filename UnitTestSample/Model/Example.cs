﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestSample.Model
{
    public class Example
    {
        public string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
