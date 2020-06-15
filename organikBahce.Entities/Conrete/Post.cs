using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace organikBahce.Entities.Conrete
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }

        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }

        public bool isActive { get; set; }
    }
}
