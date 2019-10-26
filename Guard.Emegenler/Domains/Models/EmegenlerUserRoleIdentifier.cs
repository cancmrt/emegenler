using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Guard.Emegenler.Domains.Models
{
    public class EmegenlerUserRoleIdentifier
    {
        [NotMapped]
        private IEmegenlerUWork UWork { get; set; }
        [Key]
        public int RoleIdentifierId { get; set; }
        public string UserIdentifier { get; set; }
        public string RoleIdentifier { get; set; }

        public void Update()
        {
            var result = UWork.UserRoles.Insert(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void Delete()
        {
            var result = UWork.UserRoles.Delete(this);
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
