using System.Collections.Generic;

namespace SimpleChat.Data
{
    public interface IRepository
    {
        void Add(Message entity);
        IEnumerable<Message> GetAll();
        int SaveChanges();
    }
}
