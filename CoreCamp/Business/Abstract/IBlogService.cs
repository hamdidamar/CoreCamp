﻿using Entities.Concrete;
using Shared.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService:IService<Blog>
    {
        List<Blog> GetBlogsWithCategory();
    }
}
