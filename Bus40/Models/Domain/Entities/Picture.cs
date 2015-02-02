using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bus40.Models.Domain.Entities
{
    public class Picture
    {
        public virtual Guid Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Path { get; set; }
    }
}