﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    class Task53
    {
        public string GetStudentsAvg(Node<Student> DB)
        {
            Node<Student> copyDB = DB;
            string finalString = "\n----Avreges----\n";
            while (copyDB != null)
            {
                int GradesLength = copyDB.GetValue().Grades.GetSize();
                double sum = 0;
                string courses = "Coureses: ";

                Node<Grade> tmp = copyDB.GetValue().Grades;
                while (tmp != null)
                {
                    sum += tmp.GetValue().Precentage;
                    courses += tmp.GetValue().CourseId + "; ";
                    tmp = tmp.GetNext();
                }

                finalString += $"\n---- {copyDB.GetValue().ToString()} ----\n{courses}\nTotal avarage: {sum / GradesLength}\n";

                copyDB = copyDB.GetNext();
            }
            return finalString;
        }

        public KeyValuePair<int, double> GetBestAvgCourse(Node<Student> DB)
        {
            Dictionary<int, List<double>> courseDict = new Dictionary<int, List<double>>();
            Node<Student> copyDB = DB;

            while (copyDB != null)
            {
                Node<Grade> tmp = copyDB.GetValue().Grades;
                while (tmp != null)
                {
                    int courseId = tmp.GetValue().CourseId;
                    double grade = tmp.GetValue().Precentage;
                    if (courseDict.ContainsKey(courseId))
                    {
                        courseDict[courseId].Add(grade);
                    }
                    else
                    {
                        courseDict[courseId] = new List<double> { grade };
                    }

                    tmp = tmp.GetNext();

                }
                copyDB = copyDB.GetNext();
            }

            KeyValuePair<int, double> maxAvgCourse = new KeyValuePair<int, double>(int.MinValue, double.MinValue);
            foreach (KeyValuePair<int, List<double>> entry in courseDict)
            {
                double currentAvg = GetListAvg(entry.Value);
                if (currentAvg > maxAvgCourse.Value)
                {
                    maxAvgCourse = new KeyValuePair<int, double>(entry.Key, currentAvg);
                }
            }
            return maxAvgCourse;
        }
        private double GetListAvg(List<double> list)
        {
            double sum = 0;
            int count = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum / count;
        }
        public class Student
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public int Year { get; set; }
            public Node<Grade> Grades { get; set; }

            public Student(string name, int id, int year, Node<Grade> grades)
            {
                Name = name;
                Id = id;
                Year = year;
                Grades = grades;
            }

            public override string ToString()
            {
                return $"Name: {Name}; Id: {Id}; Year: {Year}";
            }
        }

        public class Grade
        {
            public int CourseId { get; set; }
            public double Precentage { get; set; }

            public Grade(int courseId, double precentage)
            {
                CourseId = courseId;
                Precentage = precentage;
            }
        }
    }
}
