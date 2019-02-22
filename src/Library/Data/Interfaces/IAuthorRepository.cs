using Library.Data.Model;
using System.Collections.Generic;

namespace Library.Data.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllWitBooks();
        Author GetWithBooks(int id);
    }
}
