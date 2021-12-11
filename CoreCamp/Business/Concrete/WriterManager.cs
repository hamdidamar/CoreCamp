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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public IDataResult<Writer> Add(Writer entity)
        {
            return _writerDal.Add(entity);
        }

        public IResult Delete(Writer entity)
        {
            return _writerDal.Delete(entity);
        }

        public IDataResult<Writer> Get(Expression<Func<Writer, bool>> filter)
        {
            return _writerDal.Get(filter);
        }

        public IDataResult<List<Writer>> GetAll(Expression<Func<Writer, bool>> filter = null)
        {
            return _writerDal.GetAll(filter);
        }

        public IDataResult<Writer> Update(Writer entity)
        {
            return _writerDal.Update(entity);
        }
    }
}
