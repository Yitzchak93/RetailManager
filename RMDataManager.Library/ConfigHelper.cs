using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDataManager.Library
{
    public class ConfigHelper 
    {
        // TODO: Move this from config to the API
        public static decimal GetTaxRate()
        {
            string rate = ConfigurationManager.AppSettings["taxRate"];
            bool isValid = decimal.TryParse(rate, out decimal output);

            if (isValid == false)
            {
                throw new ConfigurationErrorsException("The tax rate is not set up property");
            }
            return output;
        }
    }
}
