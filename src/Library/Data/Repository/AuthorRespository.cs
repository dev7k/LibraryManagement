using Library.Data.Interfaces;
using Library.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Library.Data.Repository
{
    public class AuthorRespository : Repository<Author>, IAuthorRepository
    {
        public AuthorRespository(LibraryDbContext context) : base(context)
        {
        }

        public IEnumerable<Author> GetAllWitBooks()
        {
            return _context.Authors.Include(a => a.Books);
        }

        public Author GetWithBooks(int id)
        {
            return _context.Authors
                .Where(a => a.AuthorId == id)
                .Include(a => a.Books)
                .FirstOrDefault();
        }
    }
}
