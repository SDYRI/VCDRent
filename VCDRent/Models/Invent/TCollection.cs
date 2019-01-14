using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/********************************************************************************************************
 *  Header File: TCollection.cs
 *  Description: VCD Collection Information use to CRUD
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
 *  Written by SDY_RI <satriya.dedy.wm@gmail.com>, October 2018
 ********************************************************************************************************/

namespace VCDRent.Models.Invent
{
    public class TCollection
    {
        public int collectionID { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string TitleCollection { get; set; }
        [Display(Name = "Description")]
        public string DescriptionCollection { get; set; }
    }
}
