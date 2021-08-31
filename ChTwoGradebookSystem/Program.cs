using System;

namespace ChTwoGradebookSystem
{
    class Program
    {
        static void Main()
        {
            /*
             * Coding Challenge #2
                Create a Gradebook System
                Write a program which will ask the user to input a certain number of students. Then, ask the user
                how many tests were administered to the students.
                For each student, ask the user to input the first name of the student, the last name of the student,
                and each numerical grade of the tests for the student.
                For each student, calculate the grade average (sum of all test scores / number of tests) and a letter
                grade based on the following table.
                Numerical Grade Letter Grade
                90 – 100 A
                80 – 89 B
                70 – 79 C
                60 – 69 D
                0 – 59 F
                Create a class that holds all the student’s information and any methods needed.
                Then output each student’s first and last name, grade average, and letter grade to the user.
            */

            Student[] students;
            EnterNumber("number of students", out int numberOfStudents);
            students = new Student[numberOfStudents];

            EnterNumber("number of tests", out int numberOfTests);

            for (int i = 0; i < numberOfStudents; i++)
            {
                students[i] = new Student
                {
                    Grades = new int[numberOfTests]
                };
                Console.WriteLine($"Enter the name for student number {i + 1}");
                students[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter the lastname for student number {i + 1}");
                students[i].LastName = Console.ReadLine();

                for (int j = 0; j < numberOfTests; j++)
                {
                    EnterNumber($"the grade of test number {j + 1}", out students[i].Grades[j]);
                }
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }

        }
        private static void EnterNumber(string msg, out int number)
        {
            Console.WriteLine($"Enter a number for {msg}:");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"Enter a valid value for {msg}:");
            };
        }
    }
}

