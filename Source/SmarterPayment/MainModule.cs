﻿using System;
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
            Get["/"] = (args) => View["Index"];
            Get["/mu-d6235ad9-7bb860d1-37dcb55d-226fde09.txt"] = (args) => "42";
        }
    }
}