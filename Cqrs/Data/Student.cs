﻿using System.ComponentModel.DataAnnotations;

namespace Cqrs.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
    }
}
