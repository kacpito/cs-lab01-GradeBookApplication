﻿using System;
using System.Collections.Generic;
using System.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeight) : base (name, isWeight)
        {
            Name = name;
            Type = GradeBookType.Standard;
        }
    }
}
