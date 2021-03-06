﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id=1, Name="Mary", Department = "HR", Email="mary@gmail.com" },
                new Employee() {Id=2, Name="John", Department = "IT", Email="John@gmail.com" },
                new Employee() {Id=3, Name="Harry", Department = "IT", Email="Harry@gmail.com" },
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == Id); 

            throw new NotImplementedException();
        }
    }
}
