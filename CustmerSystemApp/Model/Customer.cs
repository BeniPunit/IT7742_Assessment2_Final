using System;

namespace CustomerSystemApp.Model
{
    public class Customer
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public Customer(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public Customer() { }
    }
}
