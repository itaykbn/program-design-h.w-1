using System;
using System.Collections.Generic;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //_Task2();

            //_Task48();

            _Task53();
        }

        private static void _Task2()
        {
            Task2 task2 = new Task2();
            List<Task2.RangeNode> rangeList = task2.CreateRangeList(new List<int> { 3, 4, 5, 12, 19, 20, 100, 101, 102, 103, 104 });
            for (int i = 0; i < rangeList.Count; i++)
            {
                Console.Write($"[{rangeList[i].From},{rangeList[i].To}] ");
                Console.Write("--> ");
            }
            Console.Write("Null");
        }

        private static void _Task48()
        {
            Task48 task48 = new Task48();
            Node<string> Representation = task48.GetRepresentation(
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("R", 1),
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("L", 3),
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("S", 4)))));

            Console.WriteLine(Representation.GetString());
        }

        private static void _Task53()
        {

            Task53 task53 = new Task53();

            Node<Task53.Grade> gradeItay =
                new Node<Task53.Grade>(new Task53.Grade(8819516, 80),
                new Node<Task53.Grade>(new Task53.Grade(8819517, 85),
                new Node<Task53.Grade>(new Task53.Grade(8819518, 90))));

            Node<Task53.Grade> gradeMiki =
            new Node<Task53.Grade>(new Task53.Grade(8819516, 79.3),
            new Node<Task53.Grade>(new Task53.Grade(8819517, 87.4),
            new Node<Task53.Grade>(new Task53.Grade(8819518, 88.25))));

             
            Node<Task53.Student> DB = new Node<Task53.Student>(new Task53.Student("Itay", 987264534, 2020,gradeItay),
            new Node<Task53.Student>(new Task53.Student("Miki", 487264534, 2020, gradeMiki)
            ));

            Node<Task53.Student> copy1 = DB;
            Node<Task53.Student> copy2 = DB;



            string result1 = task53.GetStudentsAvg(copy1);
            Console.WriteLine(result1);

            Console.WriteLine("");
            KeyValuePair<int, double> result2 = task53.GetBestAvgCourse(copy2);
            Console.WriteLine($"Best average course: {result2.Key}; Avarge: {result2.Value}");
            
        }




    }
}
