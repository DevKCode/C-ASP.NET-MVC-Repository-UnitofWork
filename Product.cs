using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Key_onBoarding.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public float Price{ get; set; }
    }
}