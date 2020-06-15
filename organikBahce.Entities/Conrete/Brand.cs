using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}
