using Library.Data.Model;
using System;
using System.Collections.Generic;

namespace Library.Data.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllWithAuthor();
        IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate);
        IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate);
    }
}
