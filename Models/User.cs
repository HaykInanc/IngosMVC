using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingos.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set;}
        public string lastName { get; set;}
        public int age { get; set;}
        public virtual ICollection<Post> Posts { get; set; }
        public User()
        {
            Posts = new List<Post>();
        }


    }
}
