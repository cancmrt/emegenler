using System.ComponentModel.DataAnnotations;

namespace Guard.Emegenler.Domains.Models
{
    public class EmegenlerRole
    {
        [Key]
        public int RoledId { get; set; }
        public string RoleIdentifier { get; set; }
    }
}
