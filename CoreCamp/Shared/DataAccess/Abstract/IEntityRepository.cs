using Shared.Entities;
using Shared.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        IDataResult<T> Get(Expression<Func<T, bool>> filter);
        IDataResult<T> Add(T entity);
        IDataResult<T> Update(T entity);
        IResult Delete(T entity);
    }
}
