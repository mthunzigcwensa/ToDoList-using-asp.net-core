using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Title")]
        public string Title { get; set;}
        [Required]
        [MaxLength(80)]
        [DisplayName("Description")]
        public string Description { get; set;}
        public string Status { get; set; } = "pending";

        public DateTime? CompletionDate { get; set;}
    }
}
