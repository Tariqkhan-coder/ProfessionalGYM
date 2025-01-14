﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ProfessionalGYM.Models.BaseEntity
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; } = false;
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(25)]
        public string AddedBy { get; set; } = "";
        public DateTime AddedDate { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(25)]
        public string UpdatedBy { get; set; } = "";
        public DateTime UpdatedDate { get; set; }

    }
}
