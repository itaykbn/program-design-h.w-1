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

            //_Task53();
            _Task14();
        }

        private static void _Task2()
        {
            Task2 task2 = new Task2();
            Data data = Data.Instance;
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

            Data data = Data.Instance;

            Console.WriteLine(task48.GetRepresentation(data.Representation).GetString());
        }

        private static void _Task53()
        {

            Task53 task53 = new Task53();

            Data data = Data.Instance;

            string result1 = task53.GetStudentsAvg(data.GradeDB);
            Console.WriteLine(result1);

            Console.WriteLine("");

            KeyValuePair<int, double> result2 = task53.GetBestAvgCourse(data.GradeDB);
            Console.WriteLine($"Best average course: {result2.Key}; Avarge: {result2.Value}");

        }

        private static void _Task14()
        {
            Task14 task14 = new Task14();
            Data data = Data.Instance;
            Console.WriteLine(task14.BiggestBuildings(data.Buildings));



        }
    }
}
