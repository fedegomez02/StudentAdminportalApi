using Microsoft.EntityFrameworkCore;
using StudentAdminportalApi.models;

namespace StudentAdminportalApi.repo
{
    public class sqlRepo : IRepo
    {
        private readonly StudentAdminContext _context;  

        public sqlRepo(StudentAdminContext context)
        {
            _context = context; 
        }
        public async Task<List<Client>> GetClientsAsync()
        {
          
                return await _context.Client.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
            
        }
    }
}
