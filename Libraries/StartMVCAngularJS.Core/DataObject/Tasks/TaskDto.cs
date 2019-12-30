using StartMVCAngularJS.Core.DataObject.Entities;
using StartMVCAngularJS.Core.DataObject.People;
using StartMVCAngularJS.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMVCAngularJS.Core.DataObject.Tasks
{
    public class TaskDto : EntityDto
    {
        public TaskDto()
        {
            CreationTime = DateTime.Now;
            State = TaskState.Active;
        }
        [ForeignKey("AssignedPersonId")]
        public virtual PersonDto AssignedPerson { get; set; }
        public virtual Guid? AssignedPersonId { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual TaskState State { get; set; }
    }
}
