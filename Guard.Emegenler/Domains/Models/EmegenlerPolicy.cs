using Guard.Emegenler.FluentInterface.Policy.Types;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Guard.Emegenler.Domains.Models
{
    public class EmegenlerPolicy
    {
        [NotMapped]
        private IEmegenlerUWork _uWork { get; set; }
        [Key]
        public int PolicyId { get; set; }
        public AuthBase AuthBase { get; set; }
        public string AuthBaseIdentifier { get; set; }
        public string PolicyElement { get; set; }
        public string PolicyElementIdentifier { get; set; }
        public string AccessProtocol { get; set; }

        public void Update()
        {
            var result = _uWork.Policies.Insert(this);
            if(result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void Delete()
        {
            var result = _uWork.Policies.Delete(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void LoadEmegenlerDALToEntity(IEmegenlerUWork uWOrk)
        {
            _uWork = uWOrk;
        }
    }
}
