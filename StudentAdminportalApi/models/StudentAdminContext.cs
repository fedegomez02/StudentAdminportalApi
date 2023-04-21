using Microsoft.EntityFrameworkCore;

namespace StudentAdminportalApi.models
{
    public class StudentAdminContext: DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
