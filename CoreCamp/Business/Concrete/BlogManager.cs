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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public IDataResult<Blog> Add(Blog entity)
        {
            return _blogDal.Add(entity);
        }

        public IResult Delete(Blog entity)
        {
            return _blogDal.Delete(entity);
        }

        public IDataResult<Blog> Get(Expression<Func<Blog, bool>> filter)
        {
            return _blogDal.Get(filter);
        }

        public IDataResult<List<Blog>> GetAll(Expression<Func<Blog, bool>> filter = null)
        {
            return _blogDal.GetAll(filter);
        }

        public List<Blog> GetBlogsWithCategory()
        {
            return _blogDal.GetBlogsWithCategory();
        }

        public IDataResult<Blog> Update(Blog entity)
        {
            return _blogDal.Update(entity);
        }
    }
}
