using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookify.Domain.Shared
{
    public record class Currency
    {
        internal static readonly Currency None = new("");
        public static readonly Currency Usd = new("USD");
        public static readonly Currency Brl = new("BRL");
        private Currency(string code) => Code = code;
        public string Code { get; init; }
        
        public static Currency FromCode(string code){
            return All.FirstOrDefault(c => c.Code == code) ??
                throw new ApplicationException("The Currency code is invalid!");
        }
        public static readonly IReadOnlyCollection<Currency> All = new []{
            Usd,
            Brl
        };
    }
}