using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VCDRent.Data;
using VCDRent.Models.Invent;
using VCDRent.Models.SyncfusionViewModels;

/********************************************************************************************************
 *  Header File: PackageController.cs
 *  Description: CRUD API Package
 *    History:
 *      Date        Programmer       - Description
 *      ----------  ---------------  ----------------------------
 *      10/08/2018  Author           - Created
 *      
 *  Copyright (c) SDY_RI, 2018
 *  
 *  This file is part of VCDRent
 * 
 *  Unauthorized copying of this file, via any medium is strictly prohibited
 *  Proprietary and confidential
 *  Written by SDY_RI <satriya.dedy.wm@gmail.com>, Oktober 2018
 ********************************************************************************************************/

namespace VCDRent.Controllers.Api
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PackageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Package
        [HttpGet]
        public async Task<IActionResult> GetPackage()
        {
            List<TPackage> Items = await _context.TPackage.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<TPackage> payload)
        {
            TPackage package = payload.value;
            _context.TPackage.Add(package);
            _context.SaveChanges();
            return Ok(package);
        }

        [HttpPost("[action]")]
        public IActionResult Edit([FromBody]CrudViewModel<TPackage> payload)
        {
            TPackage package = payload.value;
            _context.TPackage.Update(package);
            _context.SaveChanges();
            return Ok(package);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<TPackage> payload)
        {
            TPackage package = _context.TPackage
                .Where(x => x.packageID == (int)payload.key)
                .FirstOrDefault();
            _context.TPackage.Remove(package);
            _context.SaveChanges();
            return Ok(package);

        }
    }
}