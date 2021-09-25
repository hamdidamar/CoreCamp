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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public IDataResult<About> Add(About entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(About entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<About> Get(Expression<Func<About, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<About>> GetAll(Expression<Func<About, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<About> Update(About entity)
        {
            throw new NotImplementedException();
        }
    }
}
