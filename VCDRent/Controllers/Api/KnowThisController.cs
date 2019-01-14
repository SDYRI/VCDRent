using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using VCDRent.Data;
using VCDRent.Models.Invent;
using VCDRent.Models.SyncfusionViewModels;

/********************************************************************************************************
 *  Header File: KnowThisController.cs
 *  Description: CRUD API Know This
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
    public class KnowThisController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public KnowThisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/KnowThis
        [HttpGet]
        public async Task<IActionResult> GetKnowThis()
        {
            List<TKnowThis> Items = await _context.TKnowThis.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<TKnowThis> payload)
        {
            TKnowThis knowThis = payload.value;
            _context.TKnowThis.Add(knowThis);
            _context.SaveChanges();
            return Ok(knowThis);
        }

        [HttpPost("[action]")]
        public IActionResult Edit([FromBody]CrudViewModel<TKnowThis> payload)
        {
            TKnowThis knowThis = payload.value;
            _context.TKnowThis.Update(knowThis);
            _context.SaveChanges();
            return Ok(knowThis);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<TKnowThis> payload)
        {
            TKnowThis knowThis = _context.TKnowThis
                .Where(x => x.knowthisID == (int)payload.key)
                .FirstOrDefault();
            _context.TKnowThis.Remove(knowThis);
            _context.SaveChanges();
            return Ok(knowThis);

        }
    }
}