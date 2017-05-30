using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleChat.Data
{
    public class MockDbMessagesRepository : IRepository
    {
        private IEnumerable<Message> _messagesList;
        private int _counter;

        public MockDbMessagesRepository(IEnumerable<Message> messagesList)
        {
            _messagesList = messagesList;
            _counter = 0;
        }

        public void Add(Message entity)
        {
            _messagesList.ToList().Add(entity);
            _counter++;
        }

        public IEnumerable<Message> GetAll()
        {
            return _messagesList.ToList();
        }

        public int SaveChanges()
        {
            return _counter;
        }
    }
}
