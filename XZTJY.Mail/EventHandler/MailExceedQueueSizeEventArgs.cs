using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZTJY.Mail.EventHandler
{
    /// <summary> 
    /// Custom Event Args for Mail event 
    /// </summary> 
    /// <remarks></remarks> 
    public class MailExceedQueueSizeEventArgs : EventArgs
    {

        private int _queueMaxSize;
        public int QueueMaxSize
        {
            get { return _queueMaxSize; }
            set { _queueMaxSize = value; }
        }
    }
}
