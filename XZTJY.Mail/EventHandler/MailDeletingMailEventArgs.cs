using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZTJY.Mail.EventHandler
{
    public class MailDeletingMailEventArgs : CancelEventArgs
    {

        private Guid _emailID;
        public Guid EmailID
        {
            get { return _emailID; }
            set { _emailID = value; }
        }
    }
}
