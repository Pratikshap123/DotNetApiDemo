using DotNetApiDemo.Models;
using EF.Core.Repository.Interface.Manager;
using EF.Core.Repository.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetApiDemo.Interfaces.Manager
{
    public interface IPostManager: ICommonManager<Post>
     {
        Post GetById(int id);
     }
}
