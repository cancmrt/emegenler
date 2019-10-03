using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Role
    {
        [Key]
        public int RoledId { get; set; }
        public string RoleName { get; set; }
    }
}
