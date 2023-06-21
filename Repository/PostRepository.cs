using DotNetApiDemo.Context;
using DotNetApiDemo.Interfaces.Repository;
using DotNetApiDemo.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetApiDemo.Repository
{
    public class PostRepository : CommonRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
