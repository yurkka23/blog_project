using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class Article : BaseModel
    { 
        public Guid UserId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;
        public bool VerifyStatus { get; set; }
        public bool isDeleted { get; set; }
        public User User { get; set; }
    }
}
