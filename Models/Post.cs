using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingos.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int likeCnt { get; set; }
    }
}
