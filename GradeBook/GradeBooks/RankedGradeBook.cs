using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeight) : base(name, isWeight)
        {
            Name = name;
            Type = GradeBookType.Ranked;
        }
        
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new ArgumentException("Not enough students!");

            double n = Students.Count / 5;
            List<double> averageStudentGrades = new List<double>();

            foreach(var student in Students)
            {
                averageStudentGrades.Add(student.AverageGrade);
            }

            averageStudentGrades.Sort();

            if (averageGrade < averageStudentGrades[(int)Math.Floor(n)])
                return 'F';
            else if (averageGrade < averageStudentGrades[(int)Math.Floor(n * 2)])
                return 'D';
            else if (averageGrade < averageStudentGrades[(int)Math.Floor(n * 3)])
                return 'C';
            else if (averageGrade < averageStudentGrades[(int)Math.Floor(n * 4)])
                return 'B';
            else
                return 'A';
        }
        
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}
