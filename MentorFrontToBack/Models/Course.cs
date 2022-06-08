using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MentorFrontToBack.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }   
        public string Catagory { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImgFile { get; set; }
        public bool isDeleted { get; set; }
        //public int TrainerId { get; set; }
        //public Trainer Trainer { get; set; }
    }
}
