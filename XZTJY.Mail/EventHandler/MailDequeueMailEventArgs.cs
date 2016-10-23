using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZTJY.Mail.Base;

namespace XZTJY.Mail.EventHandler
{
    /// <summary> 
    /// Custom Event Args for Mail event 
    /// </summary> 
    /// <remarks></remarks> 
    public class MailDequeueMailEventArgs : EventArgs
    {

        private List<Email> _emailList;
        public List<Email> EmailList
        {
            get { return _emailList; }
            set { _emailList = value; }
        }
    }

}
