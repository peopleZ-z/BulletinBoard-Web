using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.Domain
{
    public class Photo
    {
        public Guid Id { get; set; }

        public string FileReference { get; set; }

        public string Title { get; set; }

        public Guid BulletinId { get; set; }

        public Bulletin Bulletin { get; set; }
    }
}
