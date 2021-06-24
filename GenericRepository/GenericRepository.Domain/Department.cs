using System;
using System.Collections.Generic;

namespace GenericRepository.Domain
{
    public class Department:BaseEntity
    {
        public Department()
        {
            Personennels = new List<Personnel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Personnel> Personennels { get; set; }
    }
}
