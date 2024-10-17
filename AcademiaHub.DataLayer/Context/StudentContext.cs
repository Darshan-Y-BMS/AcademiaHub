using AcademiaHub.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AcademiaHub.DataLayer.Context
{

    public class StudentContext : DbContext

    {
        public StudentContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Entities.Section> Sections { get; set; }
        public DbSet<Parent> Parents { get; set; }

    }

}
