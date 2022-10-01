using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.Domain
{
    public class Comment
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public Guid OwnerId { get; set; }

        public User Owner { get; set; }

        public Guid BulletinId { get; set; }

        public Bulletin Bulletin { get; set; }
    }
}
