using System;

namespace SRPSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Calculator System Starting...");

            var insuranceCalculator = new InsuranceCalculator();
            double installmentAmount = insuranceCalculator.Calculate();

            if (installmentAmount > 0)
            {
                Console.WriteLine($"Installment Amount: {installmentAmount}");
            }
            else
            {
                Console.WriteLine("Unknown Insurance Type.");
            }
        }
    }
}