using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Policy
    {
        public string PolicyUserSelector { get; set; }
        public int PolicyId { get; set; }
        public int RoleId { get; set; }
        public string PolicyElement { get; set; }
        public string PolicyElementSelector { get; set; }
        public string AuthRole { get; set; }
    }
}
