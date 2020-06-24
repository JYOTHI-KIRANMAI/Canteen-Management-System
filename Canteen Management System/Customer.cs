using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen_Management_System
{
    class Customer
    {
        private String cusName;
        private int cusId;
        private String cusEmail;
        public Customer(String cusName, int cusId, String Email)
        {
            this.cusName = cusName;
            this.cusId = cusId;
            this.cusEmail = Email;

        }
        public String CusName { get { return this.cusName; }
            set { this.cusName = value; }}
        public int CusId { get { return this.cusId; }
            set { this.cusId = value; }}
        public String Email { get { return this.cusEmail; }
            set { this.cusEmail = value; }}

    }
}
    

