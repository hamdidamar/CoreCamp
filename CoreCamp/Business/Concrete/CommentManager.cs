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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IDataResult<Comment> Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comment> Get(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comment>> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comment> Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
