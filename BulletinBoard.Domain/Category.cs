using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.Domain
{
    public class Category
    {
        public string Title { get; set; }

        public ICollection<Bulletin> Bulletins { get; set; }
    }
}
