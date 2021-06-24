using GenericRepository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL.Repositories.Abstracts
{
    public interface IPersonelRepository:IRepository<Personnel>
    {
        IEnumerable<Personnel> GetPersonelWithDepartment();
    }
}
