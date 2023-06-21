using DotNetApiDemo.Context;
using DotNetApiDemo.Interfaces.Manager;
using DotNetApiDemo.Models;
using DotNetApiDemo.Repository;
using EF.Core.Repository.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetApiDemo.Manager
{
    public class PostManager: CommonManager<Post>,IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {

        }

        public Post GetById(int id)
        {
            //throw new NotImplementedException();
            return GetFirstOrDefault(x => x.Id == id);
        }
    }
}
