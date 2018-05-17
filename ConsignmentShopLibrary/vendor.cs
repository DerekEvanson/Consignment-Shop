using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string PublisherName { get; set; }

        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }

        public string Display
        {
            get
            {
                //0 and  1 placeholders for first and second values
                return string.Format("{0} - ${1}", PublisherName, PaymentDue); 
            }
        }
    }
}
