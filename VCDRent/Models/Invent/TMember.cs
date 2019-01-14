using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/********************************************************************************************************
 *  Header File: TMember.cs
 *  Description: Member Information use to CRUD
 *    History:
 *      Date        Programmer       - Description
 *      ----------  ---------------  ----------------------------
 *      10/08/2018  Author           - Created
 *      
 *    Relation Key :
 *      Name                              Name Model
 *      --------------------------------  ------------------------------
 *      packageID                         TPackage
 *      knowthisID                        TKnowThis
 *      memberID                          TMemberConfirmContact
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
    public class TMember
    {
        public int memberID { get; set; }
        [Required]
        [Display(Name = "Registration Date")]
        public DateTime registraiondateMember { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string fullnameMember { get; set; }
        [Display(Name = "Age")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} only number")]
        public int ageMember { get; set; }
        [Display(Name = "Phone Number")]
        public string phonenumberMember { get; set; }
        [Display(Name = "Address")]
        public string addressMember { get; set; }
        [Display(Name = "Another Rental")]
        public bool anotherRentalMember { get; set; }
        [Display(Name = "Member Status")]
        public bool statusMember { get; set; }


        // # Foreign Key #
        [ForeignKey("TPackage")]
        public int packageID { get; set; }
        public TPackage TPackage { get; set; }
        [ForeignKey("TKnowThis")]
        public int knowthisID { get; set; }
        public TKnowThis TKnowThis { get; set; }

        // # Relation #
        public ICollection<TMemberConfirmContact> TMemberConfirmContact { get; set; }
    }
}
