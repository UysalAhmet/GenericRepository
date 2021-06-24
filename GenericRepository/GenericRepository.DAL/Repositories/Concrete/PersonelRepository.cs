using GenericRepository.DAL.Repositories.Abstracts;
using GenericRepository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL.Repositories.Concrete
{
    public class PersonelRepository : Repository<Personnel>, IPersonelRepository
    {
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
        public PersonelRepository(PersonelContext context):base(context)
        {

        }
        public IEnumerable<Personnel> GetPersonelWithDepartment()
        {
            return PersonelContext.Personnels.Include("Department").ToList();
        }
    }
}
