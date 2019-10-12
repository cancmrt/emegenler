using Guard.Emegenler.Domains.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Guard.Emegenler.Domains.Models
{
    public class EmegenlerPolicy
    {
        [Key]
        public int PolicyId { get; set; }
        public string RoleIdentifier { get; set; }
        public string UserIdentifier { get; set; }
        public string PolicyElement { get; set; }
        public string PolicyElementSelector { get; set; }
        public string AuthRole { get; set; }
    }
}
