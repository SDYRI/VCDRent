using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VCDRent.Controllers.Invent
{
    [Authorize(Roles = MVC.Pages.MemberConfirmContactManage.Role)]
    public class MemberConfirmContactManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReportContact()
        {
            return View();
        }
    }
}

namespace RMISBNILife.Models
{
    public partial class ApplicationUser
    {
        [Display(Name = "MemberConfirmContactManage")]
        public bool MemberConfirmContactManageRole { get; set; } = false;
    }
}