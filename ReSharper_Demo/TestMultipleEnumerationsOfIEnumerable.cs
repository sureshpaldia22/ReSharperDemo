using ReSharper_Demo.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReSharper_Demo
{
    internal class TestMultipleEnumerationsOfIEnumerable
    {
        private ReSharper_DemoContext _dbContext;
        public TestMultipleEnumerationsOfIEnumerable()
        {
            _dbContext = new ReSharper_DemoContext();
        }

        public void Test()
        {
            var employees = _dbContext.Employees;
            DoSomething(employees);
        }

        private void DoSomething(IEnumerable<Employee> employees)
        {
            int b = employees.Count();
            int b2 = b;
            foreach (Employee a in employees)
            {
                Console.WriteLine(a.Id);
            }
        }
    }
}
