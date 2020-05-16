namespace ConsoleApp1
{
    using System;
    using System.IO;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"c:\MAGAZYN\ListaMarek.txt";
            DateTime now = DateTime.Now;
            int num2 = 0;
            DirectoryInfo info = Directory.CreateDirectory(@"c:\MAGAZYN");
            while (true)
            {
                while (true)
                {
                    int num3;
                    Console.WriteLine("*****************");
                    Console.WriteLine("*Baza danych Piw*");
                    Console.WriteLine("*****************");
                    Console.WriteLine(" ");
                    Console.WriteLine("Wybierz opcję:");
                    Console.WriteLine(" 1. Zloz zamowienie \n 2. Przejrzyj Zam\x00f3wienia \n 3. Lista Marek \n 4. Wyjdz");
                    if (!int.TryParse(Console.ReadLine(), out num3))
                    {
                        Console.Clear();
                        Console.WriteLine("****************************");
                        Console.WriteLine("*Błąd - znak inny niż cyfra*");
                        Console.WriteLine("****************************");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        switch (num3)
                        {
                            case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("1)Puszka czy 2)Butelka?");
                                int num = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (num == 1)
                                {
                                    Console.WriteLine("Podaj kolejno: \n Nazwe marki \n ID Marki \n Ilosc opakowan");
                                    Marka marka = new Marka(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Utworzono zamowienie o danych:");
                                    Console.WriteLine("Nazwa:" + marka.Nazwa);
                                    Console.WriteLine("Id:" + marka.ID_Marki);
                                    Console.WriteLine("Ilosc opakowan:" + marka.Ilosc);
                                    Console.WriteLine(marka.PodajInfoCan());
                                    Console.ReadKey();
                                    Console.Clear();
                                    path = @"c:\MAGAZYN\ListaMarek.txt";
                                    using (StreamWriter writer = File.AppendText(path))
                                    {
                                        writer.WriteLine(marka.Nazwa);
                                    }
                                    File.WriteAllLines(path, File.ReadAllLines(path).Distinct<string>());
                                    using (StreamWriter writer2 = File.AppendText(@"c:\MAGAZYN\Marka - " + marka.Nazwa + ".txt"))
                                    {
                                        writer2.WriteLine("Data zlozenia zamowienia: " + now);
                                        writer2.WriteLine("Nazwa marki: " + marka.Nazwa);
                                        writer2.WriteLine("Id marki: " + marka.ID_Marki);
                                        writer2.WriteLine("Zamowienie na ilosc: " + marka.Ilosc);
                                        writer2.WriteLine(marka.PodajInfoCan());
                                        writer2.WriteLine("__________________________________");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Podaj kolejno: \n Nazwe marki \n ID Marki \n Ilosc opakowan");
                                    Marka marka2 = new Marka(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Utworzono zamowienie o danych:");
                                    Console.WriteLine("Nazwa:" + marka2.Nazwa);
                                    Console.WriteLine("Id:" + marka2.ID_Marki);
                                    Console.WriteLine("Ilosc opakowan:" + marka2.Ilosc);
                                    Console.WriteLine(marka2.PodajInfoBottle());
                                    Console.ReadKey();
                                    Console.Clear();
                                    path = @"c:\MAGAZYN\ListaMarek.txt";
                                    using (StreamWriter writer3 = File.AppendText(path))
                                    {
                                        writer3.WriteLine(marka2.Nazwa);
                                    }
                                    File.WriteAllLines(path, File.ReadAllLines(path).Distinct<string>());
                                    using (StreamWriter writer4 = File.AppendText(@"c:\MAGAZYN\Marka - " + marka2.Nazwa + ".txt"))
                                    {
                                        writer4.WriteLine("Data zlozenia zamowienia: " + now);
                                        writer4.WriteLine("Nazwa marki: " + marka2.Nazwa);
                                        writer4.WriteLine("Id marki: " + marka2.ID_Marki);
                                        writer4.WriteLine("Zamowienie na ilosc: " + marka2.Ilosc);
                                        writer4.WriteLine(marka2.PodajInfoBottle());
                                        writer4.WriteLine("__________________________________");
                                    }
                                }
                                break;
                            }
                            case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Podaj nazwę marki kt\x00f3rej zam\x00f3wienia chcesz przejrzec \n");
                                string str3 = Console.ReadLine();
                                path = @"c:\MAGAZYN\Marka - " + str3 + ".txt";
                                Console.Clear();
                                Console.WriteLine(File.ReadAllText(path));
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Lista marek na ktore byly skladane zamowienia: \n");
                                Console.WriteLine(File.ReadAllText(@"c:\MAGAZYN\ListaMarek.txt"));
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 4:
                                num2 = 1;
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("****************************");
                                Console.WriteLine("*Błąd - Nie ma takiej opcji*");
                                Console.WriteLine("****************************");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    }
                    break;
                }
                if (num2 != 0)
                {
                    return;
                }
            }
        }
    }
}

