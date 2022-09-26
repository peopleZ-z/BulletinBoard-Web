using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.Contracts
{
    /// <summary>
    /// Bulletin board view model.
    /// </summary>
    public class BulletinBoardDto
    {
        /// <summary>
        /// Bulletin board identifier.
        /// </summary>
        public Guid BoardId { get; set; }

        /// <summary>
        /// Bulletin board title.
        /// </summary>
        public string BoardTitle { get; set; }

        /// <summary>
        /// Bulletin board offer description.
        /// </summary>
        public string BoardDescription { get; set; }

        /// <summary>
        /// Bulletin board offer price.
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// Bulletin board owner's name and link.
        /// </summary>
        public object BoardOwner { get; set; }

        /// <summary>
        /// Bulletin board owner's contacts.
        /// </summary>
        public string? OwnerContacts { get; set; }

        /// <summary>
        /// Bulletin board offer subject photos.
        /// </summary>
        public ICollection<object>? Photos { get; set; }

        /// <summary>
        /// Users comments.
        /// </summary>
        public ICollection<object>? Comments { get; set; }

        /// <summary>
        /// Bulletin board creation date.
        /// </summary>
        public DateTime BoardCreated { get; set; }

        /// <summary>
        /// When bulletin board was last updated.
        /// </summary>
        public DateTime? BoardUpdated { get; set; }


    }
}
