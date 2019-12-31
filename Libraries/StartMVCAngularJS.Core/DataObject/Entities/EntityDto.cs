
using StartMVCAngularJS.Core.Enum;
using StartMVCAngularJS.Core.Infrastructure;
using StartMVCAngularJS.Ultilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMVCAngularJS.Core.DataObject.Entities
{
    public class EntityDto : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
        public EntityDto()
        {
            Id = GuidComb.GenerateComb();
            Deleted = false;
        }
        public Guid Id { get; set; }
        
        public bool Deleted { get; set; }
    }
}
