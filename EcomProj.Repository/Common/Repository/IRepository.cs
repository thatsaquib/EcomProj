﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EcomProj.Repository.Common.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        ICollection<TEntity> GetAll();
        ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(TKey id);
        TKey Insert(TEntity model);
        bool Update(TEntity model);
        bool Remove(TKey id);
        bool Delete(TKey id);
    }
}
