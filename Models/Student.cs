﻿namespace WebApp1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Lastname} {Age}";
        }
    }
}