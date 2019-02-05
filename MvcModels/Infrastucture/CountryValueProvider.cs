using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace MvcModels.Infrastucture
{
    public class CountryValueProvider : IValueProvider{
    
        public bool ContainsPrefix(string prefix){
            return prefix.ToLower().IndexOf("country")>-1;        
        }

        public ValueProviderResult GetValue(string key){
            if (ContainsPrefix(key)) {
                return new ValueProviderResult("Germany", "Russia", CultureInfo.InvariantCulture);
            } else {
                return null;
            }
        }
    }
}