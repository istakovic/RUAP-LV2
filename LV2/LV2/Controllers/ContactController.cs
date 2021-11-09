using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace LV2.Controllers
{
    public class ContactController : ApiController
    {
        public string[] Get()
        {
            return new string[]
            {
                "Hello",
                "World"
            };
        }
    }
}