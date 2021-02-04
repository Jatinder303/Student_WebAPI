using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_WebAPI.Models;

namespace Student_WebAPI.Data
{
    public class Student_WebAPI_Database : DbContext
    {
        public Student_WebAPI_Database (DbContextOptions<Student_WebAPI_Database> options)
            : base(options)
        {
        }

        public DbSet<Student_WebAPI.Models.Student> Student { get; set; }
    }
}
