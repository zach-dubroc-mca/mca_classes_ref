namespace OOP_Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////car class usage
            //Car myCar = new Car("nissan", "pathfinder");
            //Console.WriteLine($"this car is going {myCar.Speed} MPH");
            //myCar.Accelerate(20);
            //myCar.Brake(50);

            ////employee class usage
            //Employee spongebob = new Employee("Spongebob", "Frycook", "I'm ready");
            //Employee squidward = new Employee("Squidward", "Cashier", "I hate everyone");
            //spongebob.Introduce();
            //squidward.Introduce();

            ////base animal class usage
            //Animal basic_animal = new Animal();
            //basic_animal.Speak();
            //basic_animal.Nap();

            //dog/cat class usage
            //Dog fido   = new Dog();
            //Cat oliver = new Cat();
            //fido.Speak();
            //oliver.Speak();
            //fido.Nap();
            //oliver.Nap();


            ////polymorphism example
            //List<Animal> animals = new List<Animal>();
            //animals.Add(new Animal());
            //animals.Add(new Dog());
            //animals.Add(new Cat());

            //foreach (Animal a in animals)
            //{
            //    a.Speak();
            //    a.Nap();
            //}
            
        }
    }

    // Inheritance example

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("bark bark"); 
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("meow meow"); 
        }
        public override void Nap()
        {
            Console.WriteLine("cat nap"); 
        }
    }
}
