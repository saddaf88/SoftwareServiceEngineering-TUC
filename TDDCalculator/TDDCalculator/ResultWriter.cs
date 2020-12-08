﻿using System.IO;

namespace TDDCalculator
{
    public interface IResultWriter
    {
        void WriteResult(double result);
    }

    public class ResultWriter : IResultWriter
    {
        public void WriteResult(double result)
        {
            using (var f = File.Create("test.txt"))
            using (var sw = new StreamWriter(f))
            {
                sw.WriteLine(result);
            }
        }
    }
}
