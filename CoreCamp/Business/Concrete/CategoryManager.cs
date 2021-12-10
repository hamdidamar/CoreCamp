using Business.Abstract;
using DataAccess.Abstract;
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
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> Add(Category entity)
        {
            return _categoryDal.Add(entity);
        }

        public IResult Delete(Category entity)
        {
            return _categoryDal.Delete(entity);
        }

        public IDataResult<Category> Get(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Get(filter);
        }

        public IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetAll();
        }

        public IDataResult<Category> Update(Category entity)
        {
            return _categoryDal.Update(entity);
        }
    }
}
