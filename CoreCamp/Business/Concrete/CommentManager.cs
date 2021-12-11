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
            return _commentDal.Add(entity);
        }

        public IResult Delete(Comment entity)
        {
            return _commentDal.Delete(entity);
        }

        public IDataResult<Comment> Get(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.Get(filter);
        }

        public IDataResult<List<Comment>> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.GetAll(filter);
        }

        public IDataResult<Comment> Update(Comment entity)
        {
            return _commentDal.Update(entity);
        }
    }
}
