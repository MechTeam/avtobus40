using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bus40.Models.Domain.Entities;
using Bus40.Models.Domain.Providers;
using Bus40.Models.WebTemplateObjects;

namespace Bus40.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            try
            {
                ServiceProvider provider = new ServiceProvider();
                IList<ServiceWTO> services = new List<ServiceWTO>();

                foreach (Service item in provider.GetList())
                {
                    services.Add(new ServiceWTO(item));
                }

                services.Add(new ServiceWTO(new Service())); // убрать
                services.Add(new ServiceWTO(new Service())); // убрать

                return View(services);
            }
            catch (Exception ex)
            { 

            }

            return View();
        }

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult Slider()
        {
            return View();
        }
    }
}
