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
 *  Header File: ConfirmContactController.cs
 *  Description: CRUD API Confirm Contact
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
    public class ConfirmContactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConfirmContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ConfirmContact
        [HttpGet]
        public async Task<IActionResult> GetConfirmContact()
        {
            List<TConfirmContact> Items = await _context.TConfirmContact.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<TConfirmContact> payload)
        {
            TConfirmContact confirmContact = payload.value;
            _context.TConfirmContact.Add(confirmContact);
            _context.SaveChanges();
            return Ok(confirmContact);
        }

        [HttpPost("[action]")]
        public IActionResult Edit([FromBody]CrudViewModel<TConfirmContact> payload)
        {
            TConfirmContact confirmContact = payload.value;
            _context.TConfirmContact.Update(confirmContact);
            _context.SaveChanges();
            return Ok(confirmContact);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<TConfirmContact> payload)
        {
            TConfirmContact confirmContact = _context.TConfirmContact
                .Where(x => x.confirmcontactID == (int)payload.key)
                .FirstOrDefault();
            _context.TConfirmContact.Remove(confirmContact);
            _context.SaveChanges();
            return Ok(confirmContact);

        }
    }
}