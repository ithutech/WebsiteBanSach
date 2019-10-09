using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteBanSach.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CateName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}