using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.AddUserViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewMode = new AddUserViewModel();

            return View(addUserViewMode);
        }

        [HttpPost]        
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid )
            {
                

                    SpaDay.Models.User user = new User
                    {
                        Username = addUserViewModel.Username,
                        Email = addUserViewModel.Email,
                        Password = addUserViewModel.Password,
                        VerifyPass = addUserViewModel.VerifyPass
                    };
                return View("~/Views/User/Index.cshtml", addUserViewModel);
                

            }
            return View(addUserViewModel);
        }

    }
}
