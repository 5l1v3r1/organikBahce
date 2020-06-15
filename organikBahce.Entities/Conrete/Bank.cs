using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public int BrandCode { get; set; }
        public string AccountName { get; set; }
        public int AccountCode { get; set; }
        public string IBAN { get; set; }
        public int MyProperty { get; set; }
    }
}
