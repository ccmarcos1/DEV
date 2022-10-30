using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEV.JsonObjects
{
    public class PagamentoRede
    {
        public string capture { get; set; }
        public string kind { get; set; }
        public string reference { get; set; }
        public string amount { get; set; }
        public string installments { get; set; }
        public string cardholderName { get; set; }
        public string cardNumber { get; set; }
        public string expirationMonth { get; set; }
        public string expirationYear { get; set; }
        public string securityCode { get; set; }
        public string softDescriptor { get; set; }
        public bool subscription { get; set; }
        public string origin { get; set; }
        public string distributorAffiliation { get; set; }
        public string brandTid { get; set; }
        public string storageCard { get; set; }
    }
}