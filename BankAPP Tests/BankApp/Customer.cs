namespace BankApp
{
    // customer info
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStaff { get; set; }

        public Customer(int id, string name, bool staff)
        {
            Id = id;
            Name = name;
            IsStaff = staff;
        }
    }
}
