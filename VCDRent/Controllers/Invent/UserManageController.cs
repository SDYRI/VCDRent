using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VCDRent.Models;

namespace VCDRent.Controllers.Invent
{
    [Authorize(Roles = MVC.Pages.UserManage.Role)]
    public class UserManageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserManageController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

namespace VCDRent.Models
{
    public partial class ApplicationUser
    {
        [Display(Name = "UserManage")]
        public bool UserManageRole { get; set; } = false;
    }
}