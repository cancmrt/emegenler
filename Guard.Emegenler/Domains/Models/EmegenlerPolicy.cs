using Guard.Emegenler.FluentInterface.Policy.Types;
using System.ComponentModel.DataAnnotations;

namespace Guard.Emegenler.Domains.Models
{
    public class EmegenlerPolicy
    {
        [Key]
        public int PolicyId { get; set; }
        public AuthBase AuthBase { get; set; }
        public string AuthBaseIdentifier { get; set; }
        public string PolicyElement { get; set; }
        public string PolicyElementIdentifier { get; set; }
        public string AccessProtocol { get; set; }

    }
}
