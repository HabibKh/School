using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Registration.Models;

namespace School.Registration.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                return View("Index");
            }
            
        }
    }
}