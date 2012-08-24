using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Web.Mvc;
using System.ServiceModel.Activation;

namespace WCFService
{
    [ServiceContract]
    public interface ICurrencyConverter
    {
        [OperationContract]
        IList<SelectListItem> GetCountryDropDown();

        [OperationContract]
        decimal ConvertToGoogle(decimal amount, string fromCurrency, string toCurrency);

        [OperationContract]
        decimal ConvertToYahoo(decimal amount, string fromCurrency, string toCurrency);
    }
}