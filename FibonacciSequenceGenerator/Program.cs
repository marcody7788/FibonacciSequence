using Common;
using System;

namespace FibonacciSequenceGenerator
{
    internal class Program
    {
        private const int maxNumberOfElementsToPrint = 22;
        private const int minNumberOfElementsToPrint = 7;

        public static void Main()
        {
            var inputValidator = new InputValidator(minNumberOfElementsToPrint, maxNumberOfElementsToPrint);
            var numberOfElementsToPrint = inputValidator.GetNumberOfElementsToPrint();
            var fibSequence = new FibonacciSequence(numberOfElementsToPrint);
            var fibSequencePrinter = new FibonacciSequencePrinter(fibSequence);
            Console.WriteLine();
            fibSequencePrinter.Print();
            Console.WriteLine();
            fibSequencePrinter.PrintReversed();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}