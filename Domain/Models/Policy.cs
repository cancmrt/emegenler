using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Policy
    {
        public string PolicyUserSelector { get; set; }
        [Key]
        public int PolicyId { get; set; }
        public int RoleId { get; set; }
        public string PolicyElement { get; set; }
        public string PolicyElementSelector { get; set; }
        public string AuthRole { get; set; }
    }
}
