using System;
using System.Web.Mvc;

namespace MvcModels.Infrastucture
{
    public class CustomValueProviderFactory : ValueProviderFactory{
    
        public override IValueProvider GetValueProvider(ControllerContext controllerContext){
            return new CountryValueProvider();
        }
    }
}