using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMVCAngularJS.Domain.ViewModels
{
    public class TaskViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? AssignedPersonId { get; set; }
        public string Description { get; set; }
        public DateTime? CreateTime { get; set; }
        public TaskStatus State { get; set; }
        public bool Deleted { get; set; }
    }
}
