using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Headline
    {
        public int HeadlineId { get; set; }
        public List<Comment>? Comments { get; set; }
        public string Context { get; set; } = string.Empty;
        public required User User { get; set; }
        public int UserId { get; set; }
    }
}
