using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class Lab3
{

    public static void Main(string[] args)
    {
        zad1();
        zad2();
    }

    static void zad1()
    {
        //kreowanie obiektów rgb
        RGB color1 = new RGB(0, 0, 0);
        RGB color2 = new RGB(0, 0, 0);
        RGBController.rgbInit(color1, 255, 123, 43);
        RGBController.rgbInit(color2, 34, 22, 125);
        Console.Write("Składowe pierwszego koloru: ");
        RGBController.rgbDisplay(color1);
        Console.Write("Składowe drugiego koloru: ");
        RGBController.rgbDisplay(color2);
        RGB color3 = RGBController.colorMix(color1, color2);
        Console.Write("Zmieszane kolory: ");
        RGBController.rgbDisplay(color3);
    }
    static void zad2()
    {
        int userInput;
        bool isEnd = false;
        Uni uni = new Uni();

        while (!isEnd)
        {
            Console.WriteLine("1. Dodaj studenta");
            Console.WriteLine("2. Usuń studenta");
            Console.WriteLine("3. Oblicz średnią ocenę dla studenta");
            Console.WriteLine("4. Oblicz średnią ocenę dla wszystkich studentów");
            Console.WriteLine("5. Wyświetl wszystkich studentów");
            Console.WriteLine("6. Koniec");

            try
            {
                userInput = Convert.ToInt16(Console.ReadLine());
                int index;

                switch (userInput)
                {
                    case 1:
                        uni.dodajStudenta();
                        break;
                    case 2:
                        Console.WriteLine("Indeks studenta do usunięcia: ");
                        try
                        {
                            index = Convert.ToInt32(Console.ReadLine());
                            uni.usunStudenta(index);
                        }
                        catch
                        {
                            Console.WriteLine("To nie jest indeks");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Indeks studenta, któremu ma być policzona średnia");
                        try
                        {
                            index = Convert.ToInt32(Console.ReadLine());
                            uni.obliczSrednia(index);
                        }
                        catch
                        {
                            Console.WriteLine("To nie jest indeks");
                        }
                        break;
                    case 4:
                        uni.obliczSredniaAll();
                        break;
                    case 5:
                        uni.wyswietlStudentow();
                        break;
                    case 6:
                        isEnd = true;
                        break;
                    default:
                        Console.WriteLine("Błędna opcja");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Błędna opcja");
            }
        }
    }
} 
