using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Key_onBoarding.Models
{
    public class ProductSold
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateSold { get; set; }

    }
}