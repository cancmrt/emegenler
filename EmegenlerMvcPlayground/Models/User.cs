using System.Collections.Generic;

namespace EmegenlerMvcPlayground.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<UsersGroup> Groups { get; set; }

    }
}
