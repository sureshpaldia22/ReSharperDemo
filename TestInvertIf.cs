using System;

namespace ReSharper_Demo
{
    internal class TestInvertIf
    {
        public void Test()
        {
            DoSomething(2);
        }

        public void DoSomething(int a)
        {
            if (a > 1)
            {
                int b = a * 10;
                if (a > 500)
                {
                    int c = b * 20;
                    if (c > 500)
                    {
                        Console.WriteLine("We did something!");
                    }
                }
            }
        }
    }
}
