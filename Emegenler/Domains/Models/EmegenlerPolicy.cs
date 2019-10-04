using Emegenler.Domains.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Emegenler.Domains.Models
{
    public class EmegenlerPolicy
    {
        [Key]
        public int PolicyId { get; set; }
        public int RoleId { get; set; }
        public string UserIdentifier { get; set; }
        public EmegenlerElementType PolicyElement { get; set; }
        public string PolicyElementSelector { get; set; }
        public EmegenlerAuthRoleType AuthRole { get; set; }
    }
}
