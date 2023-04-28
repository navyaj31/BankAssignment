namespace Assignment5bank
{
    class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Village { get; set; }
        public string Mobileno { get; set; }
        public string RandomId { get; set; }
    }
    class Bank
    {
        int n = 0;
        Customer[] customers;
        public void details()
        {
            Console.WriteLine("Enter no of customers:");
            n = Convert.ToInt32(Console.ReadLine());
            customers = new Customer[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Enter first name of customer {i + 1}");
                string firstname = Console.ReadLine();
                Console.WriteLine($"Enter last name of customer {i + 1}");
                string lastname = Console.ReadLine();
                Console.WriteLine($"Enter village name of customer {i + 1}");
                string villagename = Console.ReadLine();

                Console.WriteLine($"Enter mobile number of {i + 1}");
                string mobileno = Console.ReadLine();
                if (mobileno.Length != 10)
                {
                    Console.WriteLine("please enter a valid number ");
                    mobileno = Console.ReadLine();
                }
                customers[i] = new Customer() { Firstname = firstname, Lastname = lastname, Village = villagename, Mobileno = mobileno };
            }
        }
        public void randomCustomerid()
        {
            for (int i = 0; i < n; i++)
            {
                string firstname = customers[i].Firstname;
                string lastname = customers[i].Lastname;
                Random rnd = new Random();
                int randomNum = rnd.Next(100, 999);
                string randomid = $"{lastname}{randomNum}";
                Console.WriteLine($"CustomerId: {randomid}");
                customers[i].RandomId = randomid;
            }
        }
        public void show()
        {
            Console.WriteLine("Enter last name of the customer:");
            string lname = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (customers[i].Lastname == lname)
                {
                    Console.WriteLine($"{customers[i].Firstname}\t{customers[i].Lastname}\t{customers[i].Village}\t{customers[i].Mobileno}\t{customers[i].RandomId}");

                }
            }
        }
        public void village()
        {
            Console.WriteLine("enter a village name");
            string vname = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (customers[i].Village == vname)
                {
                    Console.WriteLine($"{customers[i].Firstname} \t {customers[i].Lastname} \t {customers[i].Village}  \t {customers[i].Mobileno} \t {customers[i].RandomId}");
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.details();
            bank.randomCustomerid();
            bank.show();
            bank.village();

        }
    }
}
