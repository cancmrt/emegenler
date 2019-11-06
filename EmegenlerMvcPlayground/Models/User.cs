using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmegenlerMvcPlayground.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Group> UserGroups { get; set; }

    }
}
