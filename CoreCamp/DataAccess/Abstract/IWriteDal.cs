﻿using Entities.Concrete;
using Shared.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IWriteDal : IEntityRepository<Writer>
    {
    }
}
