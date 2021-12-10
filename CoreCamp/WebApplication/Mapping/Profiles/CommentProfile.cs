using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Mapping.Profiles
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<ICommentService, CommentManager>();
            
        }
    }
}
