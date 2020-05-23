using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppsWebApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool Complete { get; set; }
    }
}
