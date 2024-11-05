using System;

namespace FibonacciSequenceGenerator
{
    internal class InputValidator
    {
        private readonly int maxNumberOfElementsAllowed;
        private readonly int minNumberOfElementsAllowed;

        public InputValidator(int minNumberOfElementsAllowed, int maxNumberOfElementsAllowed)
        {
            this.minNumberOfElementsAllowed = minNumberOfElementsAllowed;
            this.maxNumberOfElementsAllowed = maxNumberOfElementsAllowed;
        }

        internal int GetNumberOfElementsToPrint()
        {
            var requestMessage = $"Please enter a number between {minNumberOfElementsAllowed} and {maxNumberOfElementsAllowed}";
            Console.WriteLine($"{requestMessage} (and press ENTER) to generate the first N numbers of Fibonacci sequence.");
            var userInputText = Console.ReadLine();
            int fibNumber;
            while (!int.TryParse(userInputText, out fibNumber) || fibNumber < minNumberOfElementsAllowed || fibNumber > maxNumberOfElementsAllowed)
            {
                Console.WriteLine(requestMessage);
                userInputText = Console.ReadLine();
            }
            return fibNumber;
        }

    }
}
