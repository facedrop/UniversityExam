﻿namespace UniversityExam.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public bool Subscribe { get; set; }
    }
}
