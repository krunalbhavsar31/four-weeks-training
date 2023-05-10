namespace Animal // Note: actual namespace depends on the project name.
{
    abstract class Animal
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public abstract void MakeSound();
    }

    class Dog : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
        public void Move()
        {
            Console.WriteLine("The dag says: Woof Woof");
        }
    }
    class Cat : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public void Move()
        {
            Console.WriteLine("The cat says: Meow Meow");
        }
    }

    interface IMovable
    {
        void Move();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //dog.MakeSound();
            //dog.Move();

            //Cat cat = new Cat();
            //cat.MakeSound();
            //cat.Move();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog { Name = "Bruno", Age = 5 });
            animals.Add(new Cat { Name = "Kitty", Age = 3 });

            foreach (Animal animal in animals)
            {
                animal.MakeSound();

                if (animal is IMovable)
                {
                    IMovable movable = (IMovable)animal;
                    movable.Move();
                }
            }
        }
    }
}