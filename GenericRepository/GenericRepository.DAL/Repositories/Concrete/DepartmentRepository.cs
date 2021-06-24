using GenericRepository.DAL.Repositories.Abstracts;
using GenericRepository.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
        public DepartmentRepository(PersonelContext context): base(context)
        {
          
        }
        public IEnumerable<Department> GetDepartmentsWithPersonels()
        {
            return PersonelContext.Departments.Include("Personnels").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonelContext.Departments.Take(count);
        }
    }
}
