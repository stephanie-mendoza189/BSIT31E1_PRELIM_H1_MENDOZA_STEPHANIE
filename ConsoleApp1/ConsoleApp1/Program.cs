using System;
string[] names = new string[100];
int[,] grades = new int[100, 3];
int count = 0;

int option;


do { 
    Console.WriteLine(" ===== STUDENT SYSTEM C# ===== ");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View All Students");
    Console.WriteLine("3. Compute Average Grade");
    Console.WriteLine("4. Find Highest Grade");
    Console.WriteLine("5. Exit");
    Console.WriteLine("==========================");
    Console.Write("Choose an option: ");


    option = Convert.ToInt32(Console.ReadLine());

    if (option == 1) {
        Console.WriteLine("");
        Console.Write("Enter student name: ");
        names[count] = Console.ReadLine();

        Console.Write("Enter grade 1: ");
        grades[count, 0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter grade 2: ");
        grades[count, 1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter grade 3: ");
        grades[count, 2] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Student added successfully!");
        count++;
    }

    else if (option == 2) {
        Console.WriteLine("");
        for (int i = 0; i < count; i++) {
        int sum = grades[i, 0] + grades[i, 1] + grades[i, 2];
        double avg = sum / 3.0;

        Console.WriteLine("Name: " + names[i]);
        Console.WriteLine("Grades: " + grades[i, 0] + ", " + grades[i, 1] + ", " + grades[i, 2]);
        Console.WriteLine("Average: " + avg.ToString("F2"));
        Console.WriteLine();
            }
    }

    else if (option == 3) {
        Console.WriteLine("");
        double total = 0;

        for (int i = 0; i < count; i++) {
        int sum = grades[i, 0] + grades[i, 1] + grades[i, 2];
        total += sum / 3.0;
        }

    double classAvg = 0;

        if (count > 0) {
        classAvg = total / count;
        }

    Console.WriteLine("===== CLASS AVERAGE =====");
    Console.WriteLine("Overall Average Grade: " + classAvg.ToString("F2"));
    }

    else if (option == 4) {
        Console.WriteLine("");
        int highest = -1;
        string topStudent = " ";

        for (int i = 0; i < count; i++) {

            for (int x = 0; x < 3; x++){

                if (grades[i, x] > highest){
                highest = grades[i, x];
                topStudent = names[i];
                }
            }
        }

    Console.WriteLine("===== HIGHEST GRADE =====");
    Console.WriteLine("Top Student: " + topStudent);
    Console.WriteLine("Highest Grade: " + highest);
    }

    else if (option == 5) {
     Console.WriteLine("");
     Console.WriteLine("Exiting program...");
     Console.WriteLine("Goodbye!");
    }

    else {
     Console.WriteLine("");
     Console.WriteLine("Invalid option!");
    }

    Console.WriteLine();

 } 

while (option != 5) ;

//Gumanakanapls try ulit lmao


//Lewis > Kimi

//Lokiii



