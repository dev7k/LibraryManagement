using Library.Data.Model;
using System.Collections.Generic;

namespace Library.ViewModel
{
    public class LendViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
