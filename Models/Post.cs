using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetApiDemo.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Title.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please Enter Description.")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
