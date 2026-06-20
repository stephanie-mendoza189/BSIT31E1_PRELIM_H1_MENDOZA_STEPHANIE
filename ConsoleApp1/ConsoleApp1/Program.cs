
using System;

string[] names = new string[100];
int[,] grades = new int[100, 3];
//int count = 0;


//type hereeeee

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
        //type here
    }

    else if (option == 2)
    {
        //type here
    }

    else if (option == 3)
    {
        //type here
    }

    else if (option == 4)
    {
        //type heree
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
while (option != 5);