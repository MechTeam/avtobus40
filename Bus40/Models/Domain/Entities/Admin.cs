using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bus40.Models.Domain.Entities
{
    public class Admin
    {
        public virtual Guid Id { get; protected set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual string Email { get; set; }
    }
}