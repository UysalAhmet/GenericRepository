using GenericRepository.Domain;
using System;
using System.Data.Entity;

namespace GenericRepository.DAL
{
    public class PersonelContext:DbContext
    {
        public PersonelContext() : base(@"Server=DESKTOP-M8ABMNI\SQLEXPRESS;Database=PersonelDb;Trusted_Connection=True;")
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
    }
}
