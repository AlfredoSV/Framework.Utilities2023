﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities.Email.IServices
{
    public  interface IServiceEmail
    {
        void SendEmail(string email, string emailTo,
            Guid idBodyEmail, Dictionary<string, string> paramsBody);
    }
}
