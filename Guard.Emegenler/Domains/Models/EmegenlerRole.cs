using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Guard.Emegenler.Domains.Models
{
    public class EmegenlerRole
    {
        [NotMapped]
        private IEmegenlerUWork UWork { get; set; }
        [Key]
        public int RoledId { get; set; }
        public string RoleIdentifier { get; set; }

        public void Update()
        {
            var result = UWork.Roles.Insert(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void Delete()
        {
            var result = UWork.Roles.Delete(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void LoadEmegenlerDALToEntity(IEmegenlerUWork uWOrk)
        {
            UWork = uWOrk;
        }
    }
}
