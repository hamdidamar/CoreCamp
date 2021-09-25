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
            throw new NotImplementedException();
        }

        public IResult Delete(Writer entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Writer> Get(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Writer>> GetAll(Expression<Func<Writer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Writer> Update(Writer entity)
        {
            throw new NotImplementedException();
        }
    }
}
