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
 *  Header File: MemberConfirmContactController.cs
 *  Description: CRUD API For Confirm Member to active
 *    History:
 *      Date        Programmer       - Description
 *      ----------  ---------------  ----------------------------
 *      10/09/2018  Author           - Created
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
    public class MemberConfirmContactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MemberConfirmContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MemberConfirmContact
        [HttpGet]
        public async Task<IActionResult> GetMemberConfirmContact()
        {
            List<TMemberConfirmContact> Items = await _context.TMemberConfirmContact.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpGet("[action]")]
        public IActionResult GetMemberConfirmContactAll()
        {
            var Items = _context.TMemberConfirmContact
                .Include(m => m.TConfirmContact)
                .Include(m => m.TMember)
                .Where(mc => !mc.verificationMemberConfirmContact)
                .ToList().Select(mc =>
                    new
                    {
                        tgl_contact = mc.registraiondateMemberConfirm,
                        nama_contact = mc.TConfirmContact.nameConfirmContact,
                        phone_contact = mc.TConfirmContact.phonenumberConfirmContact,
                        nama_member = mc.TMember.fullnameMember,
                        alamat_member = mc.TMember.addressMember,
                        tlp_member = mc.TMember.phonenumberMember,
                        tgl_member = mc.TMember.registraiondateMember,
                    }
                );

            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<TMemberConfirmContact> payload)
        {
            TMemberConfirmContact memberConfirmContact = payload.value;
            memberConfirmContact.registraiondateMemberConfirm = DateTime.Now;

            _context.TMemberConfirmContact.Add(memberConfirmContact);
            _context.SaveChanges();


            bool activeMember = IsCheckConfirm(memberConfirmContact.memberID);
            if(activeMember)
            {
                TMember member = _context.TMember
                .Where(x => x.memberID == memberConfirmContact.memberID)
                .FirstOrDefault();

                member.statusMember = true;

                _context.TMember.Update(member);
                _context.SaveChanges();
            }
            
            return Ok(memberConfirmContact);
        }

        [HttpPost("[action]")]
        public IActionResult Edit([FromBody]CrudViewModel<TMemberConfirmContact> payload)
        {
            TMemberConfirmContact memberConfirmContact = payload.value;
            memberConfirmContact.registraiondateMemberConfirm = DateTime.Now;

            _context.TMemberConfirmContact.Update(memberConfirmContact);
            _context.SaveChanges();

            bool activeMember = IsCheckConfirm(memberConfirmContact.memberID);
            if (activeMember)
            {
                TMember member = _context.TMember
                .Where(x => x.memberID == memberConfirmContact.memberID)
                .FirstOrDefault();

                member.statusMember = true;

                _context.TMember.Update(member);
                _context.SaveChanges();
            }

            return Ok(memberConfirmContact);
        }

        public bool IsCheckConfirm (int memberId)
        {
            bool result = false;
            try
            {
                List<TMemberConfirmContact> Items = _context.TMemberConfirmContact.ToList();
                Items = _context.TMemberConfirmContact.ToList()
                    .Where(
                        uk => (uk.memberID == memberId
                                && uk.verificationMemberConfirmContact
                               )).ToList();
                int Count = Items.Count();

                if (Count == 2)
                {
                    result = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
}