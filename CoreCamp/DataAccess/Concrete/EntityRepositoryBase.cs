using Microsoft.EntityFrameworkCore;
using Shared.DataAccess.Abstract;
using Shared.Entities;
using Shared.Results.Abstract;
using Shared.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public IDataResult<TEntity> Add(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

                return new SuccessDataResult<TEntity>(entity, "Added", true);
            }
        }

        public IResult Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

                return new SuccessResult("Deleted");
            }
        }


        public IDataResult<TEntity> Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

                return new SuccessDataResult<TEntity>(entity, "Updated", true);
            }
        }

        IDataResult<TEntity> IEntityRepository<TEntity>.Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return new SuccessDataResult<TEntity>(context.Set<TEntity>().SingleOrDefault(filter));
            }
        }

        IDataResult<List<TEntity>> IEntityRepository<TEntity>.GetAll(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? new SuccessDataResult<List<TEntity>>(context.Set<TEntity>().ToList())
                    : new SuccessDataResult<List<TEntity>>(context.Set<TEntity>().Where(filter).ToList());
            }
        }
    }
}
