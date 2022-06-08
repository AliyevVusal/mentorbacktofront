using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorFrontToBack.Models
{
    public class Trainer
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Titel { get; set; }
        public bool isDeleted { get; set; }
        //public DateTime CreatDateTime { get; set; }
        //List<Course> Courses { get; set; }

    }
}
