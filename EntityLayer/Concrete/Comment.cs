using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public required User User { get; set; }
        public int UserId { get; set; }
        public int HeadlineId { get; set; }
        public required Headline Headline { get; set; }
        public string CommentText { get; set; } = string.Empty;
    }
}