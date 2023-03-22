using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPFix
{
    public class InsurancePolicySerializer
    {
        public InsurancePolicy GetInsurancePolicyFromJsonString(string policyTxt)
        {
            return JsonConvert.DeserializeObject<InsurancePolicy>(policyTxt, new StringEnumConverter());
        }
    }
}
