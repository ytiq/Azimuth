using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Azimuth.Models.Interfaces;
using Ninject;
using Ninject.Web.Common;

namespace Azimuth.Models
{
    public class User: IUser
    {
        public string Message()
        {
            return "Hello world from some user";
        }
    }
}