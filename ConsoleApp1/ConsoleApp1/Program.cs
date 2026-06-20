
using System;
using ConsoleApp1;
using static ConsoleApp1.StudentSystemFunction;

string[] names = new string[100];
int[,] grades = new int[100, 3];
int count = 0;


StudentSystemFunction studentSystem = new StudentSystemFunction();

int option;

do
{
    Console.WriteLine(" ===== STUDENT SYSTEM ===== ");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View All Students");
    Console.WriteLine("3. Compute Average Grade");
    Console.WriteLine("4. Find Highest Grade");
    Console.WriteLine("5. Exit");
    Console.WriteLine("==========================");
    Console.Write("Choose an option: ");

    option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        studentSystem.AddStudent(names, grades, ref count);
    }

    else if (option == 2)
    {
        studentSystem.ViewStudents(names, grades, count);

    }

    else if (option == 3)
    {
        studentSystem.ComputeAverage(grades, count);

    }

    else if (option == 4)
    {
        studentSystem.FindHighestGrade(names, grades, count);

    }

    else if (option == 5)
    {
        Console.WriteLine("");
        Console.WriteLine("Exiting program...");
        Console.WriteLine("Goodbye!");
    }

    else
    {
        Console.WriteLine("");
        Console.WriteLine("Invalid option!");
    }

    Console.WriteLine();

 } 

while (option != 5) ;

//comment
