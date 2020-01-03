using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMVCAngularJS.Domain.ViewModels
{
    public class PersonViewModel
    {
        [Key]
        public Guid Id { get; set; } 
        public string Name { get; set; }
    }
}
