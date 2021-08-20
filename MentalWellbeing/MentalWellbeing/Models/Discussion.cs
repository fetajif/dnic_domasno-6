using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentalWellbeing.Models
{
    public enum WhoCanAdd
    {
        Friends,
        Experts,
        All
    };
    public class Discussion
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public WhoCanAdd Privacy { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        
        public Discussion()
        {
            Comments = new List<Comment>();
        }
    }
}
