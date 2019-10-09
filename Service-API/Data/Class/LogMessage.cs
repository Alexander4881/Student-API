using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service_API.Data.Emum;
using static Service_API.Data.Emum.Enums;

namespace Service_API.Data.Class
{
    class LogMessage
    {
        // attributes
        private string message;
        private MessageType messageType;

        // properties
        public string Message { get => message; private set => message = value; }
        public MessageType MessageType { get => messageType; private set => messageType = value; }

        // constructor
        public LogMessage(string message, MessageType messageType)
        {
            Message = message;
            MessageType = messageType;
        }
    }
}
