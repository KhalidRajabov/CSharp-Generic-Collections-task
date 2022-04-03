using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount.Models
{
    internal class Student
    {
        private static int _ident = 0;
        public int Ident { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        private int _point;
        public int Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value > 100 || value < 1)
                {
                    Console.WriteLine("Points can not be 0 or more than 100 or less than 0");
                    return;
                }
                else
                {

                    _point = value;
                    _ident++;
                    
                    return;
                }

            }
        }
        public Student()
        {
            Ident = _ident;
        }
        public Student(string name, string surname, int age, int point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"\n" +
                $"Student Id number: {_ident} \n" +
                $"Student name: {Name}\n" +
                $"Student surname: {Surname}\n" +
                $"Studnet point: {Point} \n" +
                $"\n" +
                $"");
        }

    }
}
