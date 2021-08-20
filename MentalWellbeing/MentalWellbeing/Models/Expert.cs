using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentalWellbeing.Models
{
    public class Expert
    {

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageURL { get; set; }
        public string Biography { get; set; }
        public ICollection<Comment> Messages { get; set; }

        public Expert()
        {
            Messages = new List<Comment>();
        }
    }
}
