using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Book : BaseEntity
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Resume { get; set; }
        public string ISBN { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public string Author { get; set; }
        public ICollection<Review> Reviews { get; set; }


    }
}
