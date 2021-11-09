using LV2.Models;
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
        public Contact[] Get()
        {
            return new Contact[]
            {
        new Contact
        {
            Id = 1,
            Name = "Glenn Block"
        },
        new Contact
        {
            Id = 2,
            Name = "Dan Roth"
        }
            };
        }
    }
}