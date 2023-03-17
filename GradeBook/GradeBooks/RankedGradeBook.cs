﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Name = name;
            Type = GradeBookType.Ranked;
        }
        /*
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new ArgumentException("Not enough students!");

            int N = Students.Count / 5;
        }
        */
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStatistics();
        }
    }
}
