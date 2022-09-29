using ReSharper_Demo.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReSharper_Demo
{
    public class TestSqlInjection
    {
        private ReSharper_DemoContext _dbContext;

        public TestSqlInjection()
        {
            _dbContext = new ReSharper_DemoContext();
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
