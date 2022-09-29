using System;
using Microsoft.EntityFrameworkCore;
using ReSharper_Demo.DB.Models;
using System.Linq;

namespace ReSharper_Demo
{
    public class TestSqlInjection
    {
        private ReSharper_DemoContext _dbContext;

        public TestSqlInjection()
        {
            _dbContext = new ReSharper_DemoContext();
            string b = "";

            try
            {
                if (1 == 1)
                {
                    Console.WriteLine("What?");
                }
            }
            catch
            {
            }
        }

        public void Test()
        {
            //string name = "s";
            string name = "s%'; DELETE FROM Employees WHERE name like '%";
            var employees = _dbContext.Employees.FromSqlRaw("SELECT * FROM Employees WHERE Name like '%" + name + "%'")
                .ToList();
        }
    }
}
