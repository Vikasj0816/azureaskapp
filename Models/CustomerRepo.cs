using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagementProject.Models
{
    public class CustomerRepo:IRepo<Customer>
    {
        public List<Customer> customers { get; set; }
        public CustomerRepo()
        {
            customers = new List<Customer>();
        }
        public void AddItem(Customer item)
        {
            customers.Add(item);
        }
        public IEnumerable<Customer> GetItems()
        {
            return customers;
        }
    }
}
