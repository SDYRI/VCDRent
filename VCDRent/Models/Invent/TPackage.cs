using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/********************************************************************************************************
 *  Header File: TPackage.cs
 *  Description: Package Information use to CRUD
 *    History:
 *      Date        Programmer       - Description
 *      ----------  ---------------  ----------------------------
 *      10/08/2018  Author           - Created
 *      
 *    Relation Key :
 *      Name                              Name Model
 *      --------------------------------  ------------------------------
 *      packageID                         TMember
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
    public class TPackage
    {
        public int packageID { get; set; }
        [Required]
        [Display(Name = "Package Name")]
        public string namePackage { get; set; }
        [Display(Name = "Package Max")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} only number")]
        public int maxPackage { get; set; }
        [Display(Name = "Package Cost")]
        [DataType(DataType.Currency)]
        public double costPackage { get; set; }

        // # Relation #
        public ICollection<TMember> TMembers { get; set; }
    }
}
