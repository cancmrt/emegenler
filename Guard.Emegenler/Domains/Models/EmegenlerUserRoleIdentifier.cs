using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Guard.Emegenler.Domains.Models
{
    public class EmegenlerUserRoleIdentifier
    {
        [Key]
        public int RoleIdentifierId { get; set; }
        public string UserIdentifier { get; set; }
        public string RoleIdentifier { get; set; }
    }
}
