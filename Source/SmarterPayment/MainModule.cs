using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace SmarterPayment
{
    public class MainModule : NancyModule 
    {
        public MainModule()
        {
            Get["/"] = (args) => "Test";
        }
    }
}