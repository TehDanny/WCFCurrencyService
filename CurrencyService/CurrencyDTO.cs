﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CurrencyService
{
    [DataContract]
    public class CurrencyDTO
    {
        [DataMember]
        private string name;
        [DataMember]
        private string ISO;
        [DataMember]
        private decimal exchangeRate;

        public CurrencyDTO(string name, string ISO, decimal exchangeRate)
        {
            this.name = name;
            this.ISO = ISO;
            this.exchangeRate = exchangeRate;
        }

        internal static List<CurrencyDTO> GetCurrencies()
        {
            List<CurrencyDTO> currencyList = new List<CurrencyDTO>()
            {
                new CurrencyDTO("America", "USD", 524.02M),
                new CurrencyDTO("Canada", "CAD", 492.27M),
                new CurrencyDTO("Euro", "EUR", 745.99M),
                new CurrencyDTO("Norway", "NOK", 90.34M),
                new CurrencyDTO("Great Britain", "GBP", 947.53M),
                new CurrencyDTO("Sweden", "SEK", 78.21M)
            };

            return currencyList;
        }
    }
}