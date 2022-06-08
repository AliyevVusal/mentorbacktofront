using Microsoft.EntityFrameworkCore;
using MentorFrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorFrontToBack.DAL
{
    public class AppDbcontex : DbContext
    {

        public AppDbcontex(DbContextOptions<AppDbcontex> options):base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Trainer> Trainers { get; set; }


    }
}
