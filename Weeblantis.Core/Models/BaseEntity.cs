using System;
using System.Collections.Generic;
using System.Text;

namespace Weeblantis.Core.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedAt { get; set; } 
        public DateTime DeletedAt { get; set; } 

    }
}
