﻿using System;
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
 *  Header File: MemberController.cs
 *  Description: CRUD API Member
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
    public class MemberController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MemberController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Member
        [HttpGet]
        public async Task<IActionResult> GetMember()
        {
            List<TMember> Items = await _context.TMember.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<TMember> payload)
        {
            TMember member = payload.value;
            _context.TMember.Add(member);
            _context.SaveChanges();
            return Ok(member);
        }

        [HttpPost("[action]")]
        public IActionResult Edit([FromBody]CrudViewModel<TMember> payload)
        {
            TMember member = payload.value;
            _context.TMember.Update(member);
            _context.SaveChanges();
            return Ok(member);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<TMember> payload)
        {
            TMember member = _context.TMember
                .Where(x => x.memberID == (int)payload.key)
                .FirstOrDefault();
            _context.TMember.Remove(member);
            _context.SaveChanges();
            return Ok(member);

        }
    }
}