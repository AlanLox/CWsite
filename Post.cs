using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWsite
{

    public class Post
    {
        public DateTime Time { get; }
        public string Author { get; set; }
        public string Message { get; }

        public Post(DateTime time, string author, string message)
        {
            Time = time;
            Author = author;
            Message = message;
        }
    }
}
