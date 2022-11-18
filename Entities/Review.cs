using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Review : BaseEntity
    {
        public User User { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public Book Book { get; set; }

    }
}
