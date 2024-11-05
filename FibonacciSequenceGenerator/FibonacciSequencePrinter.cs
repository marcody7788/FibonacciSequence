using Common;
using System;

namespace FibonacciSequenceGenerator
{
    internal class FibonacciSequencePrinter
    {
        private readonly FibonacciSequence fibonacciSequence;
        private const string elementSeparator = " ";

        public FibonacciSequencePrinter(FibonacciSequence fibonacciSequence)
        {
            this.fibonacciSequence = fibonacciSequence;
        }

        public void Print()
        {
            Console.WriteLine("Fibonacci sequence:");
            Console.WriteLine(string.Join(elementSeparator, fibonacciSequence.Elements));
        }

        public void PrintReversed()
        {
            Console.WriteLine("Reversed Fibonacci sequence:");
            Console.WriteLine(string.Join(elementSeparator, fibonacciSequence.ReversedElements));
        }

    }
}
