using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

public class Uni
{
    private float[] listaDopuszczalnychOcen = { 2.0f, 3.0f, 3.5f, 4.0f, 4.5f, 5.0f };
    private List<Student> listaStudentów = new List<Student>();

    public void dodajStudenta()
    {
        int index, year;
        string name, lastName;
        List<float> grades = new List<float>();

        try
        {
            Console.WriteLine("Imię studenta");
            name = Console.ReadLine();
            Console.WriteLine("Nazwisko studenta");
            lastName = Console.ReadLine();
            Console.WriteLine("Index studenta");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rok studenta");
            year = Convert.ToInt32(Console.ReadLine());

            string userInput;
            bool nextGrade = true;
            float grade;
            Console.WriteLine("Dodawanie ocen: ");
            while (nextGrade)
            {
                Console.WriteLine("Dodać następną ocenę [t/n]");
                userInput = Console.ReadLine();
                if (userInput == "t")
                {
                    Console.WriteLine("Dodaj ocenę");
                    grade = (float)Convert.ToDouble(Console.ReadLine());
                    if (listaDopuszczalnychOcen.Contains(grade))
                    {
                        grades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine("Nie jest do prawidłowa ocena");
                    }
                }
                else if (userInput == "n")
                {
                    nextGrade = false;
                }
                else
                {
                    Console.WriteLine("Niepoprawny wybór");
                }

            }
            Student studend = new Student(index, name, lastName, year);
            studend.Grades = grades;
            listaStudentów.Add(studend);
        }
        catch
        {
            Console.WriteLine("Błędny format");
        }
    }
    public void usunStudenta(int index)
    {
        Student studentToRemove = listaStudentów.Find(st => st.Index == index);
        if (studentToRemove != null)
        {
            listaStudentów.Remove(studentToRemove);
            Console.WriteLine("Usunięto studenta");
        }
        else
        {
            Console.WriteLine("Brak studenta o podanym indeksie");
        }
    }
    public void obliczSrednia(int index)
    {
        Student st = listaStudentów.Find(st => st.Index == index);
        if (st != null)
        {
            float avg = 0;
            foreach (var grade in st.Grades)
            {
                avg += grade;
            }
            avg /= st.Grades.Count;
            Console.WriteLine($"Indeks: {index}, średnia: {avg}");
        }
        else
        {
            Console.WriteLine("Brak studenta o podanym indeksie");
        }
    }
    public void obliczSredniaAll()
    {
        float gradesSum = 0;
        float gradesCount = 0;
        float avg = 0;
        foreach (var student in listaStudentów)
        {
            foreach (var grade in student.Grades)
            {
                gradesSum += grade;
                gradesCount++;
            }
        }
        avg = gradesSum / gradesCount;
        Console.WriteLine($"Średnia wszystkich studentów: {avg}");
    }
    public void wyswietlStudentow()
    {
        if (listaStudentów.Count > 0)
        {
            foreach (var item in listaStudentów)
            {
                Console.WriteLine($"{item.Name} {item.LastName}, {item.Index}, {item.Year}");
            }
        }
        else
        {
            Console.WriteLine("Brak studentow");
        }
    }
}