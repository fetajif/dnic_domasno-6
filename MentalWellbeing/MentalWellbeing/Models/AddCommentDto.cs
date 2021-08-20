using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentalWellbeing.Models
{
    public class AddCommentDto
    {
        public Discussion Discussion { get; set; }
        public Guid CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
