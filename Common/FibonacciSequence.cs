using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class FibonacciSequence
    {
        private readonly int numberOfElements;
        private List<int> elements = new List<int>();

        public FibonacciSequence(int numberOfElements)
        {
            this.numberOfElements = numberOfElements;
        }

        public List<int> Elements
        {
            get
            {
                if (!elements.Any())
                {
                    elements = CalculateElements();
                }
                return elements;
            }
        }

        public List<int> ReversedElements => Elements.OrderByDescending(element => element).ToList();

        private List<int> CalculateElements()
        {
            var currentFibNumber = 0;
            var previousFibNumber = 0;
            for (int i = 1; i <= numberOfElements; i++)
            {
                elements.Add(currentFibNumber);
                if (i == numberOfElements) { break; } //No need to calculate the next number since it's the last iteration
                if (currentFibNumber == 0)
                {
                    currentFibNumber = 1;
                    continue;
                }
                currentFibNumber += previousFibNumber;
                previousFibNumber = currentFibNumber - previousFibNumber;
            }
            return elements;
        }

    }
}
