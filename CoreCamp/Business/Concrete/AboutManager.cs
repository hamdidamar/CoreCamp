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
            return _aboutDal.Add(entity);
        }

        public IResult Delete(About entity)
        {
            return _aboutDal.Delete(entity);
        }

        public IDataResult<About> Get(Expression<Func<About, bool>> filter)
        {
            return _aboutDal.Get(filter);
        }

        public IDataResult<List<About>> GetAll(Expression<Func<About, bool>> filter = null)
        {
            return _aboutDal.GetAll(filter);
        }

        public IDataResult<About> Update(About entity)
        {
            return _aboutDal.Update(entity);
        }
    }
}
