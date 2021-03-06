﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ90.DesktopAPI.Infrastructure.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(long id);

        Task Create(TEntity entity);

        Task Update(long id, TEntity entity);

        Task Delete(long id);
    }
}
