using Library.Data.Model;
using System.Collections.Generic;

namespace Library.Data.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAllWitBooks();
        Author GetWithBooks(int id);
    }
}
