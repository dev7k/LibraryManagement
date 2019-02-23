using Library.Data.Model;
using System.Collections.Generic;

namespace Library.ViewModel
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Author> Authors { get; set; }
    }
}
