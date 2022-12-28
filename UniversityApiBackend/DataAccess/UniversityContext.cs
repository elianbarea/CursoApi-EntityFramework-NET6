using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options): base(options) 
        {
            

        }
            //TODO: add DbSets (Tables of our data base)
            public DbSet<User>? Users { get; set; }

            public DbSet<Curso>? Cursos { get; set; }

    }
}
