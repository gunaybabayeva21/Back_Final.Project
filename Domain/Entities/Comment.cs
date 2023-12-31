﻿using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment:BaseAuditable
    {
        public Comment()
        {
            CommentLikes = new HashSet<CommentLike>();
        }
        public string Text { get; set; } = null!;
        public User User { get; set; } = null!;
        public int Rating { get; set; }
        public int UserId { get; set; } 
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
        public ICollection<CommentLike> CommentLikes { get; set; }
    }
}
