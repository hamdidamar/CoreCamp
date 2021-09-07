using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentUsername { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

    }
}
