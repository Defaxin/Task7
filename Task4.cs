

namespace ConsoleApp34
{
    abstract class Worker
    {
        public abstract void Print();
    }
    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("This is the President of the company.");
        }
    }
    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("This is the Security personnel.");
        }
    }
    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("This is the Manager of the department.");
        }
    }
    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("This is an Engineer working on projects.");
        }
    }
}
