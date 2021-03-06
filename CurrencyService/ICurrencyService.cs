﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICurrencyService" in both code and config file together.
    [ServiceContract]
    public interface ICurrencyService
    {
        [OperationContract]
        decimal DanishKronerToEuro(decimal danishKroner);

        [OperationContract]
        decimal GetExchangeRate(string iso);

        [OperationContract]
        List<CurrencyDTO> GetCurrencies();
    }
}
