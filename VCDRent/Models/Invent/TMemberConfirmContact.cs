using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/********************************************************************************************************
 *  Header File: TMemberConfirmContact.cs
 *  Description: Relation Member and Confirm Contact use to Activation User
 *    History:
 *      Date        Programmer       - Description
 *      ----------  ---------------  ----------------------------
 *      10/08/2018  Author           - Created
 *      
 *    Relation Key :
 *      Name                              Name Model
 *      --------------------------------  ------------------------------
 *      TMember                           TMember
 *      TConfirmContact                   TConfirmContact
 *      
 *  Copyright (c) SDY_RI, 2018
 *  
 *  This file is part of VCDRent
 * 
 *  Unauthorized copying of this file, via any medium is strictly prohibited
 *  Proprietary and confidential
 *  Written by SDY_RI <satriya.dedy.wm@gmail.com>, October 2018
 ********************************************************************************************************/

namespace VCDRent.Models.Invent
{
    public class TMemberConfirmContact
    {
        public DateTime registraiondateMemberConfirm { get; set; }

        public int confirmcontactID { get; set; }
        public TConfirmContact TConfirmContact { get; set; }

        public int memberID { get; set; }
        public TMember TMember { get; set; }
        
        public bool verificationMemberConfirmContact { get; set; } = false;
    }
}
