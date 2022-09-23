using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReSharper_Demo
{
    internal class TestUnreachableCode
    {
        public void Test()
        {
            DoSomething(Button.Close);
        }

        // Suggestion to make it private
        // Suggestion to make it static
        public string DoSomething(Button button)
        {
            switch (button)
            {
                case Button.Close:
                    return "a";
                    break;
            }

            return "";
        }
    }

    public enum Button
    {
        Confirm,
        Cancel,
        Close
    }
}
