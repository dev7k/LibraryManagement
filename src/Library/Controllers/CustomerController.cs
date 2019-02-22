using Library.Data.Interfaces;
using Library.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IBookRepository _bookRepository;

        public CustomerController(ICustomerRepository customerRepository,
            IBookRepository bookRepository)
        {
            _customerRepository = customerRepository;
            _bookRepository = bookRepository;
        }


        public IActionResult List()
        {
            var customerViewModel = new List<CustomerViewModel>();

            var customers = _customerRepository.GetAll();

            if (customers.Count() == 0)
            {
                return View("Empty");
            }

            foreach (var customer in customers)
            {
                customerViewModel.Add(new CustomerViewModel
                {
                    Customer = customer,
                    BookCount = _bookRepository.Count(x => x.BorrowerId == customer.CustomerId)
                });
            }

            return View(customerViewModel);
        }
    }
}
