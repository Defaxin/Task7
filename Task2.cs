

namespace ConsoleApp34
{
    class Device
    {
        public string Name { get; set; }
        public Device(string name)
        {
            Name = name;
        }
        public virtual void Sound()
        {
            Console.WriteLine("Device sound");
        }
        public void Show()
        {
            Console.WriteLine($"Device name: {Name}");
        }
        public virtual void Desc()
        {
            Console.WriteLine("Device description");
        }
    }
    class Kettle : Device
    {
        public Kettle(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine("Kettle sound: Whistle");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a Kettle used for boiling water.");
        }
    }
    class Microwave : Device
    {
        public Microwave(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine("Microwave sound: Beep");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a Microwave used for heating food.");
        }
    }
    class Car : Device
    {
        public Car(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine("Car sound: Vroom");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a Car used for transportation.");
        }
    }
    class Steamboat : Device
    {
        public Steamboat(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine("Steamboat sound: Horn");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a Steamboat used for traveling on water.");
        }
    }
}
