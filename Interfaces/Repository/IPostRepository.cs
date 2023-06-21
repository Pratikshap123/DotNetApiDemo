using DotNetApiDemo.Models;
using EF.Core.Repository.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetApiDemo.Interfaces.Repository
{
    public interface IPostRepository:ICommonRepository<Post>
    {
    }
}
