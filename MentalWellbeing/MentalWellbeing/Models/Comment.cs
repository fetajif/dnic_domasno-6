using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentalWellbeing.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }
        public string Coment { get; set; }
    }
}
