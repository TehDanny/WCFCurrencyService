using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyClient.CurrencyService;

namespace CurrencyClient
{
    class Controller
    {
        CurrencyServiceClient client;

        public Controller()
        {
            client = new CurrencyServiceClient();
        }

        internal string DanishKronerToEuro(string text)
        {
            decimal danishKroner = Convert.ToDecimal(text);
            string euro = client.DanishKronerToEuro(danishKroner).ToString("#.##");
            return euro;
        }
    }
}
