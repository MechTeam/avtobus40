using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bus40.Models.Domain.Entities;

namespace Bus40.Models.WebTemplateObjects
{
    public class ServiceWTO
    {
        private String name;
        private String description;
        private String price;
        private Picture picture;

        public ServiceWTO(Service service)
        {
            this.name = service.Name;
            this.description = service.Description;
            this.price = service.Price;
            this.picture = service.Picture;
        }

        public String Name 
        {
            get { return name; }
        }

        public String Description
        {
            get { return description; }
        }

        public String Price
        {
            get { return price; }
        }

        public Picture Picture
        {
            get { return picture; }
        }
    }
}