using Microsoft.AspNetCore.Mvc;
using System;
using TestMVCProject.Models;
using TestMVCProject.ViewModel;

namespace TestMVCProject
{
    public class HomeController :Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController()
        {
            _employeeRepository = new MockEmployeeRepository();
        }
        public ViewResult Index() 
        {
            var model= _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}
