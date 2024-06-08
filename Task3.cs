

namespace ConsoleApp34
{
    class MusicalInstrument
    {
        public string Name { get; set; }
        public MusicalInstrument(string name)
        {
            Name = name;
        }
        public virtual void Sound()
        {
            Console.WriteLine("Instrument sound");
        }
        public void Show()
        {
            Console.WriteLine($"Instrument name: {Name}");
        }
        public virtual void Desc()
        {
            Console.WriteLine("Instrument description");
        }
        public virtual void History()
        {
            Console.WriteLine("Instrument history");
        }
    }
    class Violin : MusicalInstrument
    {
        public Violin(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine("Violin sound: Screech");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a Violin, a string instrument.");
        }
        public override void History()
        {
            Console.WriteLine("The violin was first developed in the 16th century.");
        }
    }
    class Trombone : MusicalInstrument
    {
        public Trombone(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine("Trombone sound: Wah-wah");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a Trombone, a brass instrument.");
        }
        public override void History()
        {
            Console.WriteLine("The trombone originated in the 15th century.");
        }
    }
    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Ukulele sound: Plink");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a Ukulele, a small string instrument.");
        }
        public override void History()
        {
            Console.WriteLine("The ukulele was developed in the 19th century in Hawaii.");
        }
    }
    class Cello : MusicalInstrument
    {
        public Cello(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine("Cello sound: Deep");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a Cello, a larger string instrument.");
        }
        public override void History()
        {
            Console.WriteLine("The cello evolved in the 16th century.");
        }
    }
}
