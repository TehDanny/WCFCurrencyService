using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CurrencyService
{
    public class CurrencyDTO
    {
        const decimal USD = 524.02M;
        const decimal CAD = 492.27M;
        const decimal EUR = 745.99M;
        const decimal NOK = 90.34M;
        const decimal GBP = 947.53M;
        const decimal SEK = 78.21M;

        [DataMember]
        public string Name;
        [DataMember]
        public string ISO;
        [DataMember]
        public decimal ExchangeRate;
    }
}