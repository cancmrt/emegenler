using System.Collections.Generic;

namespace EmegenlerMvcPlayground.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UsersGroup> Users { get; set; }
    }
}
