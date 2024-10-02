using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    public class MinMaxSummary : SummaryStrategy
    {
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("Mininum: " + Min(numbers));
            Console.WriteLine("Maximun: "+ Max(numbers));
        }
        private int Min(List<int> numbers)
        {
            int min = numbers[0];
            foreach (int i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        private int Max(List<int> numbers) 
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
