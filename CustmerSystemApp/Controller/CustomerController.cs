using System;
using System.Collections.Generic;
using CustomerSystemApp.Model;

namespace CustomerSystemApp.Controller
{
    public class CustomerController
    {
        private List<Customer> records = new List<Customer>();

        public List<Customer> ShowAll()
        {
            return records;
        }

        public void AddNew(Customer c)
        {
            if (string.IsNullOrEmpty(c.Code) || string.IsNullOrEmpty(c.Name))
                throw new Exception("Fields cannot be empty.");
            records.Add(c);
        }

        public void EditCustomer(string code, string newName)
        {
            Customer found = records.Find(x => x.Code == code);
            if (found == null)
                throw new Exception("Customer not found.");
            found.Name = newName;
        }

        public void RemoveCustomer(string code)
        {
            Customer found = records.Find(x => x.Code == code);
            if (found == null)
                throw new Exception("Customer not found.");
            records.Remove(found);
        }
    }
}
