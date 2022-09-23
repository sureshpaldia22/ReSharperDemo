using System;

namespace ReSharper_Demo
{
    internal class TestNonInstanceMethodModifier
    {
        public void Test()
        {
            DoSomething("main.sas");
        }

        // Suggestion to make it private
        // Suggestion to make it static
        public void DoSomething(string filename)
        {
            Console.WriteLine(filename);
        }
    }
}
