using DotNetApiDemo.Context;
using DotNetApiDemo.Interfaces.Manager;
using DotNetApiDemo.Manager;
using DotNetApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
       // ApplicationDbContext _dbContext;
        IPostManager _postManager;
        //public PostController(ApplicationDbContext dbContext)
        //{
        //   // _dbContext = dbContext;
        //    _postManager = new PostManager(dbContext);
        //}

        public PostController(IPostManager postManager)
        {
            _postManager = postManager;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // var posts = _dbContext.Posts.ToList();
                var posts = _postManager.GetAll().ToList();
                return Ok(posts);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }         
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            try
            {
                var post = _postManager.GetById(id);
                if (post == null)
                {
                    return NotFound();
                }
                return Ok(post);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
           
        [HttpPost]
        public IActionResult Add(Post post)
        {
            try
            {
                post.CreatedDate = DateTime.Now;
                bool isSaved = _postManager.Add(post);
                //_dbContext.Posts.Add(post);
                //bool isSaved = _dbContext.SaveChanges() > 0;
                if (isSaved)
                {
                    return Created("", post);
                }
                return BadRequest("Post save failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Edit(Post post)
        {
            try
            {
                if (post.Id == 0)
                {
                    return BadRequest("Id is missing.");
                }
                bool isUpdate = _postManager.Update(post);
                if (isUpdate)
                {
                    return Ok(post);
                }
                return BadRequest("Post updated failed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            try
            {
                var post = _postManager.GetById(id);
                if (post == null)
                {
                    return NotFound();
                }
                bool isDelete = _postManager.Delete(post);
                if (isDelete)
                {
                    return Ok("Post has been...");
                }
                return BadRequest("change");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
            
    }
}
