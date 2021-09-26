using Entities.Concrete;
using Shared.DataAccess.Abstract;
using Shared.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal : IEntityRepository<Blog>
    {
        List<Blog> GetBlogsWithCategory();
    }
}
