using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace SRPFix
{
    /// <summary>
    /// Reads insurance policy details from a file and evaluate the insurace based on it.
    /// </summary>
    public class InsuranceCalculator
    {
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
        public InsurancePolicyLoader PolicyLoader { get; set; } = new InsurancePolicyLoader();
        public InsurancePolicySerializer PolicySerializer { get; set; } = new InsurancePolicySerializer();
        public double Calculate()
        {
            // Logging Responsibility
            Logger.Log("Start calculating insurance installment amount.");
            Logger.Log("Loading Policy File..");

            // Persistance Responsibility
            string policyTxt = PolicyLoader.LoadInsurancePolicyText();

            // Serialization Responsibility
            InsurancePolicy policy = PolicySerializer.GetInsurancePolicyFromJsonString(policyTxt);

            double amount = 0;

            switch (policy.Type)
            {
                case InsuranceType.Vehicle:
                    Logger.Log("Calculating vechile insurance installment amount");
                    amount = 0.2 * policy.Salary;
                    break;
                case InsuranceType.Medical:
                    Logger.Log("Calculating medical insurance installment amount");
                    amount = 0.1 * policy.Salary;
                    break;
                case InsuranceType.Home:
                    Logger.Log("Calculating homeinsurance installment amount");
                    amount = 0.15 * policy.Salary;
                    break;
                case InsuranceType.Life:
                    Logger.Log("Calculating life insurance installment amount");
                    amount = 0.3 * policy.Salary;
                    break;
                default:
                    Logger.Log("Unknown policy type");
                    amount = 0;
                    break;
            }

            return amount;
        }

    }
}
