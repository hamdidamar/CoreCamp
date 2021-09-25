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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IDataResult<Contact> Add(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> Get(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> GetAll(Expression<Func<Contact, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
