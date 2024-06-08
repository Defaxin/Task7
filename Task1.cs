

namespace ConsoleApp34
{
    internal class Money
    {
        public int WholePart { get; set; }
        public int FractionalPart { get; set; }

        public Money(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }
        public void Display()
        {
            Console.WriteLine($"Amount: {WholePart}.{FractionalPart:D2}");
        }
        public void SetValues(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }
    }
    class Product : Money
    {
        public string Name { get; set; }
        public Product(string name, int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {
            Name = name;
        }
        public void ReducePrice(int amount)
        {
            int totalCents = WholePart * 100 + FractionalPart;
            totalCents -= amount;

            WholePart = totalCents / 100;
            FractionalPart = totalCents % 100;
        }
        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {Name}, Price: {WholePart}.{FractionalPart:D2}");
        }
    }
}
