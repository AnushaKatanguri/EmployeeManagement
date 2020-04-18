﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }
        //public JsonResult Details()
        //{
        //    Employee model = _employeeRepository.GetEmployee(1);
        //    return Json(model);
        //}
        //public ObjectResult Details()
        //{
        //    Employee model = _employeeRepository.GetEmployee(1);
        //    return new ObjectResult(model);
        //}
        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
              Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details"
            };
            
            return View(homeDetailsViewModel);
        }
    }
}