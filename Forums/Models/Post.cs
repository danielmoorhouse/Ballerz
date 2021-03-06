﻿using System;
using System.Collections.Generic;
using System.Text;
using Ballerz.Data.Models;

namespace Ballerz.Forums.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    

        public virtual ApplicationUser User { get; set; }
        public virtual Forum Forum { get; set; }
        public virtual List<Like> Likes { get; set; }

        public virtual IEnumerable<PostReply> Replies { get; set; }
    }
}
