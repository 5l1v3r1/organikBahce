using System;
using System.Collections.Generic;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class BlogCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int OrderNo { get; set; }
        public string ImageUrl { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public bool isActive { get; set; }

        public BlogCategory ParentCategory { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
    }
}
