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
            return _contactDal.Add(entity);
        }

        public IResult Delete(Contact entity)
        {
            return _contactDal.Delete(entity);
        }

        public IDataResult<Contact> Get(Expression<Func<Contact, bool>> filter)
        {
            return _contactDal.Get(filter);
        }

        public IDataResult<List<Contact>> GetAll(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactDal.GetAll(filter);
        }

        public IDataResult<Contact> Update(Contact entity)
        {
            return _contactDal.Update(entity);
        }
    }
}
