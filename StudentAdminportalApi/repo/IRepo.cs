using StudentAdminportalApi.models;

namespace StudentAdminportalApi.repo
{
    public interface IRepo
    {
         Task<List<Client>> GetClientsAsync(); 
    }
}
