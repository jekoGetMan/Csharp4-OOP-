using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {

        static void Main(string[] args)
        {
            Duck link = new Duck(1, 1);
            link.output();
            link.Action();
            link.Eat();
            //            Console.ReadKey();

            Console.WriteLine("************************************************");

            Ostrich link1 = new Ostrich(101.1, 101.1);
            link1.Display();
            link1.Eat();
//            Console.ReadKey();

            Console.WriteLine("************************************************");

            Dog link2 = new Dog(3,3);
            link2.Action();
            link2.Eat();
            link2.Output();

            Console.WriteLine("************************************************");

            Cat link3 = new Cat(3,3);
            link3.Action();
            link3.Eat();
            link3.Output();

            Console.ReadKey();

        }
    }

    interface Ieat
    {
        void Eat();
    }

    public abstract class baseClass2
    {
        public abstract void Action();
    }

    public class Duck : baseClass2, Ieat
    {
        private double weight;
        private double age;

        public Duck(double weight, double age)
        {
            this.weight = weight;
            this.age = age;
        }

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public double Age
        {
            get => age;
            set => age = value;
        }

        public void Eat()
        {
            Console.WriteLine("I'm duck and I can eat");
        }


        public override void Action()
        {
            Console.WriteLine("I'm duck and I can fly");
        }

        public void output()
        {
            Console.WriteLine("Duck's weight is: " + this.weight + "\n" + "Duck's age is: " + this.age);
        }
    }

    public class Ostrich : Ieat
    {
        private double weight;
        private double age;

        public Ostrich(double weight, double age)
        {
            this.weight = weight;
            this.age = age;
        }

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public double Age
        {
            get => age;
            set => age = value;
        }

        public void Eat()
        {
            Console.WriteLine("I'm Ostrich and I can eat");
        }

        public void Display()
        {
            Console.WriteLine("I'm an Ostrich and my weight is" + "\t" + this.weight + " my age is: " + this.age);
        }
    }

    public class Dog : baseClass2, Ieat
    {
        private double weight;
        private double age;

        public Dog(double weight, double age)
        {
            this.weight = weight;
            this.age = age;
        }

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public double Age
        {
            get => age;
            set => weight = value;
        }

        public override void Action()
        {
            Console.WriteLine("I'm a dog and I can bark");
        }

        public void Eat()
        {
            Console.WriteLine("I'm a dog and I can eat!");
        }

        public void Output()
        {
            Console.WriteLine("I'm a dog. My weight: " + this.weight + ", My age is: " + this.Age);
        }

        
    }

    public class Cat : baseClass2, Ieat
    {
        private double weight;
        private double age;

        public Cat(double weight, double age)
        {
            this.weight = weight;
            this.age = age;
        }

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public double Age
        {
            get => age;
            set => age = value;
        }

        public override void Action()
        {
            Console.WriteLine("I'm a cat and I can mew");
        }

        public void Eat()
        {
            Console.WriteLine("I'm a dog and I can eat!");
        }

        public void Output()
        {
            Console.WriteLine("I'm a dog. My weight: " + this.weight + ", My age is: " + this.Age);
        }
    }

}

