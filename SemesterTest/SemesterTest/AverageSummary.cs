using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    public class AverageSummary : SummaryStrategy
    {
        public override void PrintSummary(List<int> numbers) 
        {
            Console.WriteLine("Average: " + Average(numbers));
        }
        public float Average(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return (float)sum/numbers.Count;
        }
    }
}
