﻿using System;
using UserAccount.Models;
namespace UserAccount
{
    internal class Program
    {
        /*enum Admin { Info = 1, CreateGroup, ShowGroups };
        enum StudentChoices { ShowStudents = 1, Get_Student_by_ID, Add_Student, Quit };*/
        static void Main(string[] args)
        {
            
           

           



            do
            {
                Console.WriteLine("\n1)Create a new group \n" +
                    "2)  Add students \n" +
                    "3) All groups and students");
                int input = Convert.ToInt32(Console.ReadLine());


                switch (input)
                {

                    #region deletedcase
                    /*case (int)Admin.CreateGroup:
                        Console.Write("\nPlease write the name of group: ");
                        string groupName = Console.ReadLine();
                        Console.Write($"Please enter the limit for the {groupName}: ");
                        int studentlimit = int.Parse(Console.ReadLine());
                        Group group_1 = new Group(groupName, studentlimit);

                        if (group_1.StdLimit != 0 && group_1.GroupNo != null)
                        {
                            Array.Resize(ref Group, Group.Length + 1);
                            Group[Group.Length - 1] = group_1;
                            Console.WriteLine($"{group_1.GroupNo} created !");
                        }
                        if (Group.Length > 0)
                        {
                            int input2;
                            do
                            {
                                Console.WriteLine("\n1) Show all students");
                                Console.WriteLine("\n2) Get student by id");
                                Console.WriteLine("\n3) Add student");
                                Console.WriteLine("\n0) Back to Main Menu");

                                input2 = Convert.ToInt32(Console.ReadLine());
                                switch (input2)
                                {

                                    case (int)StudentChoices.ShowStudents:
                                        Console.Clear();
                                        group_1.GetStudents();
                                        break;

                                    case (int)StudentChoices.Get_Student_by_ID:
                                        Console.Clear();
                                        Console.Write("Please enter the student ID: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        group_1.GetStudent(id);
                                        break;

                                    case (int)StudentChoices.Add_Student:
                                        Console.Clear();
                                        Console.Write("Enter student name: ");
                                        string stname = Console.ReadLine();
                                        Console.Write("Enter student surname: ");
                                        string stsurname = Console.ReadLine();
                                        Console.Write("Enter the point: ");
                                        int point = Convert.ToInt32(Console.ReadLine());

                                        Student student1 = new Student();
                                        group_1.AddStudent(student1);
                                        Console.ResetColor();
                                        break;

                                    case (int)StudentChoices.Quit:
                                        break;

                                }
                            } while (input2 != 0);
                        }
                        break;

                    case (int)Admin.ShowGroups:
                        Console.Clear();
                        if (Group.Length > 0)
                        {
                            foreach (Group groups in Group)
                            {
                                Console.WriteLine(groups);
                                groups.GetStudents();
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no any student registered");
                        }

                        break;*/
                    #endregion
                    case 1:
                        
                        
                        break;
                    case 2:
                        Group Group = new Group();
                        
                        Student student = new Student();
                        
                        Console.Write("Write student name: ");
                        student.Name = Console.ReadLine();

                        Console.Write("Write student surname: ");
                        student.Surname = Console.ReadLine();

                        Console.Write("Write student age: ");
                        student.Age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Write student point: ");
                        student.Point = Convert.ToInt32(Console.ReadLine());
                        Group.AddStudent(student);
                        Group.Info();
                        student.ShowInfo();
                        break;

                        default :
                        break;

                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}