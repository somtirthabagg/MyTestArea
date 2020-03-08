using System;
using System.Collections.Generic;
using System.Text;
using CustomerMVVM.Model;
using System.Diagnostics;

namespace CustomerMVVM.ViewModel
{
    class CustomerViewModel
    {
       public CustomerViewModel()
        {
            _Customer = new Customer("Somie Bag");
        }
        private Customer _Customer;

        public Customer Customer { get => _Customer; }

        public void saveChanges()
        {
            Debug.Assert(false, String.Format("The {0} was updated", Customer.Name));
        }
    }
}
