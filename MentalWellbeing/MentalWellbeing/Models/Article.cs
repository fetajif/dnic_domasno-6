using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentalWellbeing.Models
{
    public enum MentalHealthTopic
    {
        Insomnia,
        Depression,
        Stress,
        Anxiety
    };

    public class Article
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public MentalHealthTopic Topic { get; set; }

    }
}
