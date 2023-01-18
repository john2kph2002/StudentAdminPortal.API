using System.Collections.Generic;
using System.Threading.Tasks;
using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudentAsync();
    }
}
