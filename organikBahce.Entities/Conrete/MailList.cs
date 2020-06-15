using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class MailList
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime createdDate { get; set; }
        public int MailListGroupId { get; set; }
        public MailListGroup MailListGroup { get; set; }
    }
}
