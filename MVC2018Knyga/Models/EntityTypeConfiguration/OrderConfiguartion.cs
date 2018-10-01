using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVC2018Knyga.Models.EntityTypeConfiguration
{
    public class OrderConfiguartion:EntityTypeConfiguration<Order>
    {
        public OrderConfiguartion()
        {

            //kad butu ir validationcontrol ne tik serverside bet ir client-side reikia Annotation uzdet
            Property(o => o.FirstName).IsRequired();
        }
    }
}