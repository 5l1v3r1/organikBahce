using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class Adress
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string TcNumber { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public int ContryId { get; set; }
        public int MyProperty { get; set; }
        public string AdressName { get; set; }
        public string Description { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public bool isActive { get; set; }
    }
}
