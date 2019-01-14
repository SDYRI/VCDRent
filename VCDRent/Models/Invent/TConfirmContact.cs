using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/********************************************************************************************************
 *  Header File: TConfirmContact.cs
 *  Description: Contact Confirmation Member use to CRUD
 *    History:
 *      Date        Programmer       - Description
 *      ----------  ---------------  ----------------------------
 *      10/08/2018  Author           - Created
 *      
 *      Relation Key :
 *      Name                              Name Model
 *      --------------------------------  ------------------------------
 *      confirmcontactID                  TMemberConfirmContact
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
    public class TConfirmContact
    {
        public int confirmcontactID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string nameConfirmContact { get; set; }
        [Display(Name = "Phone Number")]
        public string phonenumberConfirmContact { get; set; }

        // # Relation #
        public ICollection<TMemberConfirmContact> TMemberConfirmContact { get; set; }
    }
}
