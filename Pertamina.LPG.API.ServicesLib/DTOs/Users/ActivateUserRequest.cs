﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Users
{
    public class ActivateUserRequest
    {
        public int user_id { get; set; }
        public string auth_token { get; set; }
        public string imei { get; set; }
        public string otp_code { get; set; }
    }
}