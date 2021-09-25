using Business.Abstract;
using Entities.Concrete;
using Shared.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public IDataResult<Category> Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Category> Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Category> Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
