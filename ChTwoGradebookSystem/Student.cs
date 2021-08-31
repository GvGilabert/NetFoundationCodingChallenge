using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChTwoGradebookSystem
{
    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int[] Grades { get; set; }

        public float GradesAverage()
        {
            int totalGrades = 0;
            float result = 0;

            if (Grades is not null && Grades.Length > 0)
            {
                for (int i = 0; i < Grades.Length; i++)
                {
                    totalGrades += Grades[i];
                }
                result = (float)totalGrades / Grades.Length;
            }
            return result;
        }

        public char GetLetterGrade(float grade)
        {
            char result = grade switch
            {
                < 60 =>  'F',
                < 70 =>  'D',
                < 80 =>  'C',
                < 90 =>  'B',
                >= 90 => 'A',
                _ => 'e'
            };
            return result;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nLastname: {LastName} \nGrade Average: {GradesAverage()} \nLetter Grade: {GetLetterGrade(GradesAverage())}\n";
        }
    }
}
