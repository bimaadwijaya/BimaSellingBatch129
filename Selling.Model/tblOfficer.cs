﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Selling.Model
{
    public class tblOfficer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tblOfficerId { get; set; }
        [Key]
        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string OfficerCode { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(5)]
        public string OfficerName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string OfficerPassword { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string OfficerStatus { get; set; }
    }
}
