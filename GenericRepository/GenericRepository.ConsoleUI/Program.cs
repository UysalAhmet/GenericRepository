using GenericRepository.DAL;
using System;

namespace GenericRepository.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            //unitOfWork.PersonelRepository.Add(new Domain.Personnel() { DepartmentId=1,Name = "Ahmet",LastName="Uysal", IsActive = true, CreatedDate = DateTime.Now });
            //unitOfWork.Complate();
            var personel = unitOfWork.PersonelRepository.GetById(3);
            Console.WriteLine(personel.Department.Name);
        }
    }
}
