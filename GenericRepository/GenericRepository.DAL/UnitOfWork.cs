﻿using GenericRepository.DAL.Repositories.Abstracts;
using GenericRepository.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL
{
   public class UnitOfWork : IUnitOfWork
    {
        private PersonelContext _personelContext;
        public UnitOfWork(PersonelContext context)
        {
            _personelContext = context;
            DepartmentRepository = new DepartmentRepository(_personelContext);
            PersonelRepository = new PersonelRepository(_personelContext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonelRepository PersonelRepository { get; private set; }

        public int Complate()
        {
           return _personelContext.SaveChanges();
        }

        public void Dispose()
        {
            _personelContext.Dispose();
        }
    }
}
