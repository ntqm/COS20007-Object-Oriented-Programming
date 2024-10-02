using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    public class DataAnalyser
    {
        private List<int> _numbers;
        private SummaryStrategy _strategy;
        
        public DataAnalyser(): 
            this(new List<int>(), new AverageSummary()) 
        { }
        public DataAnalyser(SummaryStrategy strategy) : 
            this(new List<int>(), strategy)
        { }
        public DataAnalyser(List<int> numbers, SummaryStrategy strategy)
        {
            _strategy = strategy;
            _numbers = numbers;
        }
        public SummaryStrategy strategy
        {
            get
            {
                return _strategy;
            }
            set
            {
                _strategy = value;
            }
        }
        public void AddNumber(int num)
        {
            _numbers.Add(num);
        }
        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);
        }
    }
}
