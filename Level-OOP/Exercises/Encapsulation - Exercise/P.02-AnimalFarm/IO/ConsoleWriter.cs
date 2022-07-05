﻿using PracticeForJudge.IO.Interfaces;
using System;

namespace PracticeForJudge.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(object value)
        => Console.Write(value);

        public void WriteLine(object value)
        => Console.WriteLine(value);
    }
}
