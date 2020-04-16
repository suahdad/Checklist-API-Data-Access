﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class RTGForm
    {
        [Key]
        [Column(TypeName = "NVARCHAR(15)")]
        public int Id { get; set; }
        public Equipment Equipment { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }

        public List<Remark> Remarks { get; set; }
        public List<Breakdown> Breakdowns { get; set; }

    }
}
