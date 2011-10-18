using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoutSphere.Domain;

namespace ShoutSphere.Web.Controllers
{
    public class SphereController : Controller
    {
        //
        // GET: /Sphere/

        public ActionResult Index(string sphereTitle)
        {
            var sphere = new Sphere()
                             {
                                 SphereTitle = sphereTitle,
                                 Shouts = new[]
                                        {
                                            new Shout{ CratedAt = DateTime.Now, ShoutSentence = "Shout 1"},
                                            new Shout{ CratedAt = DateTime.Now, ShoutSentence = "Shout 2"},
                                        }
                             };

            return View(sphere);
        }
    }
}
