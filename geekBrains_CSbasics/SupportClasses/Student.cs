using System;
using System.IO;

namespace SupportClasses
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Univercity { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }

        private int _age = 1;
        public int Age 
        {
            set
            {
                if (value < 1 || value > 120)
                    OutputHelpers.TextColor($"У студента {SecondName} {FirstName} - некорректный возраст, должено быть в диапазоне от 1 до 120", ConsoleColor.Red);
                else
                    _age = value;
            }
            get => _age;
        }
       
        private int _course;
        public int Course
        {            
            set
            {
                if (value < 1 || value > 6)
                    OutputHelpers.TextColor($"У студента {SecondName} {FirstName} - некорректный курс, должено быть в диапазоне от 1 до 6", ConsoleColor.Red);
                else
                    _course = value;
            }
            get => _course;
        }
       
        public int Group { get; set; }
        
        public string City { get; set; }

        public Student (string firstName, string secondName, string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            FirstName = firstName;
            SecondName = secondName;
            Univercity = univercity;
            Faculty = faculty;
            Department = department;
            Age = age;
            Course = course;
            Group = group;
            City = city;
        }

        public override string ToString()
        {
            return $"{SecondName,-12} {FirstName,-9}  - Возраст: {Age,-3} университет: {Univercity,-8} курс: {_course} город: {City,-10} ";            
        }
    }
}
