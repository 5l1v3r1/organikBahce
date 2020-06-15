using System;
using System.Collections.Generic;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int OrderNo { get; set; }
        public string ImageUrl { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public bool isActive { get; set; }

        public Category ParentCategory { get; set; }
        public List<Category> Categories { get; set; }
    }
}
