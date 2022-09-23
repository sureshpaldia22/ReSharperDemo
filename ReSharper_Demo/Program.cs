using System;

namespace ReSharper_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new TestUnreachableCode();
            test1.Test();
        }
    }
}
