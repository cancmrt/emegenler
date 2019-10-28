﻿using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Guard.Emegenler.Domains.Models
{
    public class EmegenlerRole
    {
        [Key]
        public int RoledId { get; set; }
        public string RoleIdentifier { get; set; }
    }
}
