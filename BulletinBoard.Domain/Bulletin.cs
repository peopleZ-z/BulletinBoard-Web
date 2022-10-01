using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.Domain
{
    public class Bulletin
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string? Contact { get; set; }

        public Guid OwnerId { get; set; }

        public User? Owner { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        public ICollection<Category>? Categories { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Photo>? Photos { get; set; }
    }
}
