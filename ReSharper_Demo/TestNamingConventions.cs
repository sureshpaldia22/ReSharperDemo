using System;

namespace ReSharper_Demo
{
    internal class TestNamingConventions
    {
        string Age = "2";

        private string MODULE = "SCE";

        public TestNamingConventions()
        {

        }

        public TestNamingConventions(string age)
        {
            Age = age;
        }

        public void Test()
        {
            DoSomething("hello!");
        }

        private void DoSomething(string text)
        {
            Console.WriteLine(text);
        }
    }
}
