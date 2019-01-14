using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/********************************************************************************************************
 *  Header File: TKnowThis.cs
 *  Description: Know This Selection
 *    History:
 *      Date        Programmer       - Description
 *      ----------  ---------------  ----------------------------
 *      10/08/2018  Author           - Created
 *      
 *    Relation Key :
 *      Name                              Name Model
 *      --------------------------------  ------------------------------
 *      knowthisID                        TMember
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
    public class TKnowThis
    {
        public int knowthisID { get; set; }
        [Required]
        [Display(Name = "Knowthis Information")]
        public string informationKnowthis { get; set; }

        // # Relation #
        public ICollection<TMember> TMembers { get; set; }
    }
}
