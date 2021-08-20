using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentalWellbeing.Models
{
    public class ArticlesFilteredByTopicDto
    {
        public List<Article> Articles { get; set; }
        public MentalHealthTopic Topic { get; set; }
    }
}
