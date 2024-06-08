namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Laptop", 1000, 99);
            product.DisplayProduct();
            product.ReducePrice(100);
            product.DisplayProduct();

            var kettle = new Kettle("Electric Kettle");
            kettle.Show();
            kettle.Desc();
            var car = new Car("Sedan");
            car.Show();
            car.Sound();
            car.Desc();

            var violin = new Violin("Classic Violin");
            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();

            Worker president = new President();
            president.Print();
            Worker security = new Security();
            security.Print();
            Worker manager = new Manager();
            manager.Print();
            Worker engineer = new Engineer();
            engineer.Print();
        }
    }
}
