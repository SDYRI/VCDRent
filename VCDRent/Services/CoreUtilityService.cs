using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VCDRent.Data;
using VCDRent.Models;

/********************************************************************************************************
 *  Header File: CoreUtilityService.cs
 *  Description: Fasilitas tambahan untuk memaksimalkan kinerja Sistem
 *    History:
 *      Date        Programmer       - Description
 *      ----------  ---------------  ----------------------------
 *      09/28/2018  Author           - Created
 *      
 *      
 *  Copyright (c) SDY_RI, 2018
 *  
 *  This file is part of VCDRent
 * 
 *  Unauthorized copying of this file, via any medium is strictly prohibited
 *  Proprietary and confidential
 *  Written by SDY_RI <satriya.dedy.wm@gmail.com>, September 2018
 ********************************************************************************************************/

namespace VCDRent.Services
{
    public class CoreUtilityService : ICoreUtility
    {
        private readonly ApplicationDbContext _dbContext;

        public CoreUtilityService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ApplicationUser> GetAccesUser(string IdUser)
        {
            var result = _dbContext.ApplicationUser
                .SingleOrDefault(u => u.Id.Equals(IdUser));
                //.Where(u => u.Id == IdUser)
                //.ToList();          
                

            yield return result;
        }

        public bool IsUserKelStruktur(string IdUser)
        {
            bool result = false;
            try
            {
                var user = _dbContext.ApplicationUser
                .SingleOrDefault(u => u.Id.Equals(IdUser));

                result = true;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
}
