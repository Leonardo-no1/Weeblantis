using System;
using System.Collections.Generic;
using System.Text;

namespace Weeblantis.Core.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
