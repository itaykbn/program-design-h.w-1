using System;
using System.Collections.Generic;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            _Task2();

            //_Task48();

            //_Task53();
        }

        private static void _Task2()
        {
            Task2 task2 = new Task2();
            Data data = new Data();
            Node<Task2.RangeNode> rangeList = task2.CreateRangeList(data.Sequence);

            Node<Task2.RangeNode> tmp = rangeList;
            string finalString = "";

            while (tmp != null)
            {
                int from = tmp.GetValue().From;
                int to = tmp.GetValue().To;
                finalString += $"({from},{to}) -->";
                tmp = tmp.GetNext();
            }
            finalString += "Null";
            Console.WriteLine(finalString);
           
        }

        private static void _Task48()
        {
            Task48 task48 = new Task48();
            Data data = new Data();

            Console.WriteLine(task48.GetRepresentation(data.Representation).GetString());
        }

        private static void _Task53()
        {

            Task53 task53 = new Task53();

            Data data = new Data();
            //Data pull2 = new Data();

            string result1 = task53.GetStudentsAvg(data.GradeDB);
            Console.WriteLine(result1);

            Console.WriteLine("");

            KeyValuePair<int, double> result2 = task53.GetBestAvgCourse(data.GradeDB);
            Console.WriteLine($"Best average course: {result2.Key}; Avarge: {result2.Value}");

        }
    }
    class Data
    {
        // ------------------------------------ task 53 ------------------------------------//

        private static Node<Task53.Grade> gradeItay =
                new Node<Task53.Grade>(new Task53.Grade(8819516, 80),
                new Node<Task53.Grade>(new Task53.Grade(8819517, 85),
                new Node<Task53.Grade>(new Task53.Grade(8819518, 90))));


        private static Node<Task53.Grade> gradeMiki =
        new Node<Task53.Grade>(new Task53.Grade(8819516, 79.3),
        new Node<Task53.Grade>(new Task53.Grade(8819517, 87.4),
        new Node<Task53.Grade>(new Task53.Grade(8819518, 88.25))));




        public readonly Node<Task53.Student> GradeDB = new Node<Task53.Student>(new Task53.Student("Itay", 987264534, 2020, gradeItay),
                new Node<Task53.Student>(new Task53.Student("Miki", 487264534, 2020, gradeMiki)));
        // ------------------------------------ task 53 ------------------------------------//


        // ------------------------------------ task 48 ------------------------------------//

        public readonly Node<Task48.TupleStrInt> Representation =
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("R", 1),
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("L", 3),
                new Node<Task48.TupleStrInt>(new Task48.TupleStrInt("S", 4))));
        // ------------------------------------ task 48 ------------------------------------//


        // ------------------------------------ task 2 ------------------------------------//

        public readonly Node<int> Sequence =
                new Node<int>(3,
                new Node<int>(4,
                new Node<int>(5,
                new Node<int>(12,
                new Node<int>(19,
                new Node<int>(20,
                new Node<int>(100,
                new Node<int>(101,
                new Node<int>(102,
                new Node<int>(103,
                new Node<int>(104)))))))))));

        // ------------------------------------ task 2 ------------------------------------//
    }
}
