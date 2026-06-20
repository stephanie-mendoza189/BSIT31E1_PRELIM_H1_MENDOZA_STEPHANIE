using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   

        public class StudentSystemFunction
        {
            public void AddStudent(string[] names, int[,] grades, ref int count)
            {
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

            public void ViewStudents(string[] names, int[,] grades, int count)
            {
                Console.WriteLine("");

                for (int i = 0; i < count; i++)
                {
                    int sum = grades[i, 0] + grades[i, 1] + grades[i, 2];
                    double avg = sum / 3.0;

                    Console.WriteLine("Name: " + names[i]);
                    Console.WriteLine("Grades: " + grades[i, 0] + ", " + grades[i, 1] + ", " + grades[i, 2]);
                    Console.WriteLine("Average: " + avg.ToString("F2"));
                    Console.WriteLine();
                }
            }

            public void ComputeAverage(int[,] grades, int count)
            {
                Console.WriteLine("");

                double total = 0;

                for (int i = 0; i < count; i++)
                {
                    int sum = grades[i, 0] + grades[i, 1] + grades[i, 2];
                    total += sum / 3.0;
                }

                double classAvg = 0;

                if (count > 0)
                {
                    classAvg = total / count;
                }

                Console.WriteLine("===== CLASS AVERAGE =====");
                Console.WriteLine("Overall Average Grade: " + classAvg.ToString("F2"));
            }

            public void FindHighestGrade(string[] names, int[,] grades, int count)
            {
                Console.WriteLine("");

                int highest = -1;
                string topStudent = "";

                for (int i = 0; i < count; i++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (grades[i, x] > highest)
                        {
                            highest = grades[i, x];
                            topStudent = names[i];
                        }
                    }
                }

                Console.WriteLine("===== HIGHEST GRADE =====");
                Console.WriteLine("Top Student: " + topStudent);
                Console.WriteLine("Highest Grade: " + highest);
            }
        }























    }
