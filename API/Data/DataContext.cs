using Microsoft.EntityFrameworkCore;
using API.Entities;
namespace API.Data{
    public class DataContext:DbContext{
        public DataContext(DbContextOptions options):base(options){}

        public DbSet<Student> Students{get;set;}
    }
}