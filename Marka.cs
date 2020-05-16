namespace ConsoleApp1
{
    using System;

    internal class Marka : Can
    {
        public string Nazwa;
        public string ID_Marki;
        public string Ilosc;

        public Marka(string Nazwa, string ID_Marki, string Ilosc)
        {
            this.Nazwa = Nazwa;
            this.ID_Marki = ID_Marki;
            this.Ilosc = Ilosc;
        }

        public string PodajInfoBottle() => 
            ("Pojemnosc opakowania:" + base.PojemnoscBottle + "\nSztuk w opakowaniu:" + base.SztukBottle);

        public string PodajInfoCan() => 
            ("Pojemnosc opakowania:" + base.PojemnoscCan + "\nSztuk w opakowaniu:" + base.SztukCan);
    }
}

