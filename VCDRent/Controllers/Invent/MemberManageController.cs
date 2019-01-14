﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VCDRent.Controllers.Invent
{
    [Authorize(Roles = MVC.Pages.MemberManage.Role)]
    public class MemberManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

namespace RMISBNILife.Models
{
    public partial class ApplicationUser
    {
        [Display(Name = "MemberManage")]
        public bool MemberManageRole { get; set; } = false;
    }
}