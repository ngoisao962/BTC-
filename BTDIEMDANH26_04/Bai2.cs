using System;
using System.Collections.Generic;
using System.Text;

namespace BTDIEMDANH
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Cat cat205 = new Cat();
            cat205.eat();
            cat205.makeSound();
            cat205.run();
            Bird bird205 = new Bird();
            bird205.eat();
            bird205.makeSound();
            bird205.fly();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Foot");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("");
        }
    }
    class Cat : Animal
    {
        public void run()
        {
            Console.WriteLine("Meo chay nhanh");

        }
        public override void eat()
        {
            Console.WriteLine("Meo an ca");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meo keu meo meo");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("Chim bay cao");

        }
        public override void eat()
        {
            Console.WriteLine("Chim an sau");
        }
        public override void makeSound()
        {
            Console.WriteLine("Chim an con trung");
        }
    }
}
