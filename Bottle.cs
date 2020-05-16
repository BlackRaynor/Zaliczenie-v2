namespace ConsoleApp1
{
    using System;

    internal class Bottle
    {
        protected string PojemnoscBottle = "0,5L";
        protected string SztukBottle = "10";

        protected void InfoBottle()
        {
            Console.WriteLine("Pojemnosc opakowania:" + this.PojemnoscBottle);
            Console.WriteLine("Sztuk w opakowaniu:" + this.SztukBottle);
        }
    }
}

