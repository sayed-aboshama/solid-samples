using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace SRPSample
{
    /// <summary>
    /// Reads insurance policy details from a file and evaluate the insurace based on it.
    /// </summary>
    public class InsuranceCalculator
    {
        public double Calculate()
        {
            Console.WriteLine("Start calculating insurance installment amount.");

            Console.WriteLine("Loading Policy File..");

            string policyTxt = File.ReadAllText("InsurancePolicy.txt");

            var policy = JsonConvert.DeserializeObject<InsurancePolicy>(policyTxt,
                new StringEnumConverter());

            double amount = 0;

            switch (policy.Type)
            {
                case InsuranceType.Vehicle:
                    Console.WriteLine("Calculating vechile insurance installment amount");
                    amount = 0.2 * policy.Salary;
                    break;
                case InsuranceType.Medical:
                    Console.WriteLine("Calculating medical insurance installment amount");
                    amount = 0.1 * policy.Salary;
                    break;
                case InsuranceType.Home:
                    Console.WriteLine("Calculating homeinsurance installment amount");
                    amount = 0.15 * policy.Salary;
                    break;
                case InsuranceType.Life:
                    Console.WriteLine("Calculating life insurance installment amount");
                    amount = 0.3 * policy.Salary;
                    break;
                default:
                    Console.WriteLine("Unknown policy type");
                    amount = 0;
                    break;
            }

            return amount;
        }

    }
}
