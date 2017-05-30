using System;
using System.Collections.Generic;

namespace SimpleChat.Data
{
    public class DbMessagesRepository : IRepository
    {
        private SimpleChatContext _dbContext;

        public DbMessagesRepository(SimpleChatContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Message entity)
        {
            _dbContext.Messages.Add(entity);
        }

        public IEnumerable<Message> GetAll()
        {
            return _dbContext.Messages;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
