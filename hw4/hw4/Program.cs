using System;
using System.Collections.Generic;
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
            Console.ReadKey();

            Console.WriteLine("************************************************");
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

        public Dog()
        {
            this.weight = weight;
            this.age = age;
        }

        public override void Action()
        {
            Console.WriteLine("");
        }
    }
}

