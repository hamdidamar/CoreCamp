using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Shared.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BlogDal : EntityRepositoryBase<Blog, Context>, IBlogDal
    {
        public List<Blog> GetBlogsWithCategory()
        {
            using (Context context = new Context())
            {
                return context.Blogs.Include(b => b.Category).ToList();
            }
        }
    }
}
