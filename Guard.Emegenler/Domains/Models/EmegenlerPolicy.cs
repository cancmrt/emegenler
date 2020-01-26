using Guard.Emegenler.FluentInterface.Policy.Types;
using System.ComponentModel.DataAnnotations;

namespace Guard.Emegenler.Domains.Models
{
    //RefactorSubject
    //Do abstact of EmegenlerPolicy and after that generate new class with inherited EmegenlerPolicy
    //and should include EmegenlerUWOrk Update Delete method. Return this class with auto mapped value.
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
