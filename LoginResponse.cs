﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MToolkit
{
    class LoginResponse
    {
        public bool Status { get; set; }
        public string Detail_Reason { get; set; }
        public string Cookie { get; set; }
        public string Channel_Name { get; set; }
        public string Channel_Link { get; set; }
    }
}
