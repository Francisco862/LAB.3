using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    private int index;
    private string name;
    private string lastName;
    private int year;

    private List<float> grades = new List<float>();

    public Student(int index, string name, string lastName, int year)
    {
        this.index = index;
        this.name = name;
        this.lastName = lastName;
        this.year = year;
    }
    public List<float> Grades
    {
        get { return grades; }
        set { grades = value; }
    }
    public int Index
    {
        get { return index; }
        set { index = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string LastName
    {

        get { return lastName; }
        set { lastName = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public void showStudentData()
    {
        Console.WriteLine($"{name} {lastName}, {index}, rok: {year}");
    }
}
