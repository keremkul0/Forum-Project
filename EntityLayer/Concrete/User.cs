using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Identity.Core;

namespace EntityLayer.Concrete
{
    public class User : IdentityUser<int>
    {
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public List<Comment>? Comments { get; set; }
        public List<Headline>? Headlines { get; set; }
    }
}
