using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZTJY.Mail.EventHandler
{
    public class MailErrorEventArgs : EventArgs
    {
        private Exception _exception;

        private MailErrorType _errorType;
        public Exception Exception
        {
            get { return _exception; }
            set { _exception = value; }
        }

        public MailErrorType ErrorType
        {
            get { return _errorType; }
            set { _errorType = value; }
        }
    }

}
