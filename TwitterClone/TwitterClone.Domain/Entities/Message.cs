using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private User _sender;
        private string _content;

        private Guid _receiverId;
        private User _receiver;
        private DateTime _sendingAt;

        public Message(Guid senderId, Guid receiverId)
        {
            _id = Guid.NewGuid();
            _senderId = senderId;
            _receiverId = receiverId;
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid senderId
        {
            get { return _senderId; }
        }
        public User Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public Guid ReceiverId
        {
            get { return _receiverId; }
        }
        public User Receiver
        {
            get { return _receiver; }
            set { _receiver = value; }
        }
        public DateTime ReceivingAt
        {
            get { return _sendingAt; }
            set { _sendingAt = value; }
        }
    }
}
