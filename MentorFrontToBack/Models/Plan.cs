using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorFrontToBack.Models
{
    public class Plan
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Desciription { get; set; }
        public bool isDeleted { get; set; }
    }
}
