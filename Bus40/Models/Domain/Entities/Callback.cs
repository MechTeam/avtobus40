using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bus40.Models.Domain.Entities
{
    public class Callback
    {
        public virtual Guid Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Phone { get; set; }
        public virtual bool IsComplete { get; set; }
    }
}