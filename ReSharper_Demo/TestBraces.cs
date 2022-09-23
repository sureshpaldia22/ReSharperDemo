using ReSharper_Demo.DB.Models;
using System;

namespace ReSharper_Demo
{
    internal class TestBraces
    {
        private ReSharper_DemoContext _dbContext;
        public TestBraces()
        {
            _dbContext = new ReSharper_DemoContext();
        }

        public void Test()
        {
            int a = GetNumber();
            if (a == 1)
                Console.WriteLine("yes!");
            else if (a == 2)
            {
                Console.WriteLine("no!");
            }
        }

        private static int GetNumber()
        {
            return 2;
        }
    }
}
