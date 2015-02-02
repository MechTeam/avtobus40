using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bus40.Models.Domain.Entities
{
    public class Bus
    {
        public virtual Guid Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Picture Picture { get; set; }
    }
}