using System;
using System.Collections.Generic;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class TransferNotification
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BankId { get; set; }
        public string Desctiption { get; set; }
        public DateTime createdDate { get; set; }
    }
}
