namespace ConsoleApp1
{
    using System;

    internal class Can : Bottle
    {
        protected string PojemnoscCan = "0,3L";
        protected string SztukCan = "20";

        protected void InfoCan()
        {
            Console.WriteLine("Pojemnosc opakowania:" + this.PojemnoscCan);
            Console.WriteLine("Sztuk w opakowaniu:" + this.SztukCan);
        }

        protected void PInfoBottle()
        {
            base.InfoBottle();
        }
    }
}

