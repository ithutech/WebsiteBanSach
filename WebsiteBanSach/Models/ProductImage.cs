using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteBanSach.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string ImagePath { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}