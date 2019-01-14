using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using VCDRent.Data;
using VCDRent.Models;
using VCDRent.Models.SyncfusionViewModels;

namespace VCDRent.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UserController(ApplicationDbContext context,
                        UserManager<ApplicationUser> userManager,
                        RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult GetUser()
        {
            //List<ApplicationUser> Items = new List<ApplicationUser>();
            //Items = _context.ApplicationUser.ToList();
            var Items = _context.ApplicationUser
                .Select(md => new
                {
                    Id = md.Id,
                    Email = md.Email,
                    FirstName = md.FirstName,
                    LastName = md.LastName,
                })
               .ToList();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetByApplicationRMISBNIUserId([FromRoute]string id)
        {
            ApplicationUser userProfile = _context.ApplicationUser.SingleOrDefault(x => x.Id.Equals(id));
            List<ApplicationUser> Items = new List<ApplicationUser>();
            if (userProfile != null)
            {
                Items.Add(userProfile);
            }
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Insert([FromBody]CrudViewModel<ApplicationUser> payload)
        {
            //Close Only register from login (SDY_RI)
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Edit([FromBody]CrudViewModel<ApplicationUser> payload)
        {
            ApplicationUser profile = payload.value;
           
            var userProfile = await _userManager.FindByIdAsync(profile.Id);
            if (userProfile != null)
            {
                userProfile.Email = profile.Email;
                userProfile.FirstName = profile.FirstName;
                userProfile.LastName = profile.LastName;
                
                _context.Update(userProfile);
                await _context.SaveChangesAsync();
            }
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete([FromBody]CrudViewModel<ApplicationUser> payload)
        {
            //var userProfile = await _context.ApplicationUser.SingleOrDefaultAsync(x => x.Id == (string)payload.key);
            //if (userProfile != null)
            //{
            //    _context.ApplicationUser.Remove(userProfile);
            //    await _context.SaveChangesAsync();
            //}

            return Ok();

        }

        [HttpPost("[action]")]
        public FileContentResult excelExport()
        {
            //bikin file baru
            ExcelPackage pck = new ExcelPackage();
            //sumber data
            var Items = _context.ApplicationUser
                .Select(md => new
                {
                    Id = md.Id,
                    Email = md.Email,
                    FirstName = md.FirstName,
                    LastName = md.LastName,
                })
               .ToList();

            //bikin worksheet worksheet 
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("User");

            //bikin header cell[baris,kolom] , nama kolom sesuaikan dengan template
            ws.Cells[1, 1].Value = "No";
            ws.Cells[1, 2].Value = "Email User";
            ws.Cells[1, 3].Value = "First Name User";
            ws.Cells[1, 4].Value = "Last Name User";


            // Inserts Data
            int no;
            for (int i = 0; i < Items.Count(); i++)
            {
                no = i + 1;
                ws.Cells[i + 2, 1].Value = no;
                ws.Cells[i + 2, 2].Value = Items[i].Email;
                ws.Cells[i + 2, 3].Value = Items[i].FirstName;
                ws.Cells[i + 2, 4].Value = Items[i].LastName;
            }

            // Agar kolom lebar nyesuaikan dengan data
            ws.Cells[1, 1].AutoFitColumns();
            ws.Cells[1, 2].AutoFitColumns();
            ws.Cells[1, 3].AutoFitColumns();
            ws.Cells[1, 4].AutoFitColumns();

            var fsr = new FileContentResult(pck.GetAsByteArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            fsr.FileDownloadName = "Data_User.xlsx";

            return fsr;
        }

    }
}