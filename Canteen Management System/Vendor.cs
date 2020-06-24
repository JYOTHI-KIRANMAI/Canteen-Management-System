using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen_Management_System
{
   public class Vendor
    {
        private String vendorName;
        private int vendorId;
        private string vendorEmail;
        //private double vendorWallet;
        public Vendor() { }
        public Vendor(String vendorName, int vendorId, String vendorEmail)
        {
            this.vendorName = vendorName;
            this.vendorId = vendorId;
            this.vendorEmail = vendorEmail;

        }
        public String VendorName { get{ return this.vendorName;}
            set { this.vendorName = value; } }
        public int VendorId { get { return this.vendorId; }
            set { this.vendorId = value; }}
        public String VendorEmail { get { return this.vendorEmail; }
            set { this.vendorEmail = value; } }
        /*public double VendorWallet { get { return this.vendorWallet; }
            set { this.vendorWallet = value; }
        }*/

    }
}