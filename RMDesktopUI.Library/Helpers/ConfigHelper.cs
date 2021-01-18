using System;
using System.Configuration;

namespace RMDesktopUI.Library.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        // TODO: Move this from config to the API
        public decimal GetTaxRate()
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