using System;

namespace DefaultInterfaceMethodsDemo
{
    // Define an interface called IAnimal
    interface IAnimal
    {
        // Declare two methods for the interface: Speak and Eat
        void Speak();
        void Eat();
    }

    // Define a new interface called IAnimalWithSleep that inherits from IAnimal
    interface IAnimalWithSleep : IAnimal
    {
        // Declare a new method for the interface: Sleep
        void Sleep()
        {
            // Provide a default implementation for the Sleep method
            Console.WriteLine("Zzz...");
        }
    }

    // Define a new interface called IAnimalWithPlay that inherits from IAnimal
    interface IAnimalWithPlay : IAnimal
    {
        // Declare a new method for the interface: Play
        void Play()
        {
            // Provide a default implementation for the Play method
            Console.WriteLine("Playing...");
        }
    }

    // Define a class called Dog that implements the IAnimalWithSleep and IAnimalWithPlay interfaces
    class Dog : IAnimalWithSleep, IAnimalWithPlay
    {
        // Provide an implementation for the Speak method
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }

        // Provide an implementation for the Eat method
        public void Eat()
        {
            Console.WriteLine("Eating dog food");
        }
    }

    // Define a class called Cat that implements the IAnimalWithSleep and IAnimalWithPlay interfaces
    class Cat : IAnimalWithSleep, IAnimalWithPlay
    {
        // Provide an implementation for the Speak method
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }

        // Provide an implementation for the Eat method
        public void Eat()
        {
            Console.WriteLine("Eating cat food");
        }
    }


    // Define the main class
    internal class Program
    {
        // Define the Main method
        static void Main(string[] args)
        {

            // Create a new instance of Dog and assign it to an IAnimalWithSleep and IAnimalWithPlay variable
            IAnimalWithSleep dog = new Dog();
            IAnimalWithPlay dogWithPlay = new Dog();

            // Call the Speak method on the dog
            dog.Speak();
            // Call the Eat method on the dog
            dog.Eat();
            // Call the Sleep method on the dog (which was inherited from the IAnimalWithSleep interface)
            dog.Sleep();
            // Call the Play method on the dog (which was inherited from the IAnimalWithPlay interface)
            dogWithPlay.Play();




            // Create a new instance of Cat and assign it to an IAnimalWithSleep and IAnimalWithPlay variable
            IAnimalWithSleep cat = new Cat();
            IAnimalWithPlay catWithPlay = new Cat();
            // Call the Speak method on the cat
            cat.Speak();
            // Call the Eat method on the cat
            cat.Eat();
            // Call the Sleep method on the cat (which was inherited from the IAnimalWithSleep interface)
            cat.Sleep();
            // Call the Play method on the cat (which was inherited from the IAnimalWithPlay interface)
            catWithPlay.Play();

        }
    }
}
