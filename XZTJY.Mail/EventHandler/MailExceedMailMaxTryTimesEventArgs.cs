﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Mail.Base;

namespace XZTJY.Mail.EventHandler
{
    /// <summary> 
    /// The custom Event Args is rised while the times that the mail trys to send is exceed. 
    /// </summary> 
    public class MailExceedMailMaxTryTimesEventArgs : EventArgs
    {
        private Email _email;
        public Email Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
