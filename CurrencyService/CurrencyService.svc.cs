using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CurrencyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CurrencyService.svc or CurrencyService.svc.cs at the Solution Explorer and start debugging.
    public class CurrencyService : ICurrencyService
    {
        public decimal DanishKronerToEuro(decimal danishKroner)
        {
            return danishKroner / 745.99M * 100;
        }
    }
}
