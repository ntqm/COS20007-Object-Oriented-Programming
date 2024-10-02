using System;

namespace SemesterTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Tran Quang Minh - Semester Test");

            DataAnalyser dataAnalyser = new DataAnalyser(new List<int>() { 1,0,4,1,7,9,6,8,7},
                new MinMaxSummary());

            dataAnalyser.Summarise();

            dataAnalyser.AddNumber(13);
            dataAnalyser.AddNumber(24);
            dataAnalyser.AddNumber(41);

            dataAnalyser.strategy = new AverageSummary();

            dataAnalyser.Summarise();
        }
    }
}