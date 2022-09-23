using ReSharper_Demo.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReSharper_Demo
{
    internal class TestUnusedCode
    {
        private ReSharper_DemoContext _dbContext;
        public TestUnusedCode()
        {
            _dbContext = new ReSharper_DemoContext();
        }

        public void Test()
        {
            // un-necessary call to DB
            List<Employee> employees = DoSomething();

            Console.WriteLine("Process completed!");
        }

        public List<Employee> DoSomething()
        {
            return _dbContext.Employees.ToList();
        }
    }
}
