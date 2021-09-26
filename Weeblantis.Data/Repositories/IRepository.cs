using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Weeblantis.Core.Models;

namespace Weeblantis.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id);
        T FindByCondition(Expression<Func<T, bool>> predicate);
    }
}
