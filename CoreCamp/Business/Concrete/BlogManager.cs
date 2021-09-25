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
    public class BlogManager : IBlogService
    {
        public IDataResult<Blog> Add(Blog entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Blog> Get(Expression<Func<Blog, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Blog>> GetAll(Expression<Func<Blog, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Blog> Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
