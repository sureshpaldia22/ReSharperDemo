using System.IO;
using System.Text;

namespace ReSharper_Demo
{
    internal class TestVar
    {
        public void Test()
        {
            DoSomething("main.sas");
        }

        public void DoSomething(string filename)
        {
            // use explicit type
            var a = Path.GetFileNameWithoutExtension(filename);

            // use var
            StringBuilder sb = new StringBuilder();
        }
    }
}
