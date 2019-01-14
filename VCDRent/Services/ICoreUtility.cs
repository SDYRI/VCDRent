using VCDRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/********************************************************************************************************
 *  Header File: ICoreUtility.cs
 *  Description: Interface Untuk Memaksimalkan kinerja sistem
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
    interface ICoreUtility
    {
        IEnumerable<ApplicationUser> GetAccesUser(string IdUser);
        bool IsUserKelStruktur(string IdUser);
    }
}
