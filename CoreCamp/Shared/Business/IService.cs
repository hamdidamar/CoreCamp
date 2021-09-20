using Shared.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Business
{
    public interface IService<TEntity>
    {
        IDataResult<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null);
        IDataResult<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        IDataResult<TEntity> Add(TEntity entity);
        IDataResult<TEntity> Update(TEntity entity);
        IResult Delete(TEntity entity);
    }
}
