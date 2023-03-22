using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPFix
{
    public class InsurancePolicyLoader
    {
        public string LoadInsurancePolicyText()
        {
            return File.ReadAllText("InsurancePolicy.txt");
        }
    }
}
