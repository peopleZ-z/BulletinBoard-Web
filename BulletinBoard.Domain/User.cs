using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.Domain
{
    public class User
    {
        public Guid Id { get; set; }

        public string Nickname { get; set; }

        public Guid RoleId { get; set; }

        public Role Role { get; set; }

        public ICollection<Bulletin> Bulletins { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
