using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZTJY.Mail.EventHandler
{
    public enum MailErrorType
    {
        GetQueueCount,
        Enqueue,
        Dequeue,
        UpdateFailure,
        Delete,
        GetNextSendInterval,
        SendMail
    }
}
