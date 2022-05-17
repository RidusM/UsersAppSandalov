using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAppSandalov.Scripts
{
    class Order
    {
        [Key]
        public int ID_Order { get; set; }

        private string Status, PaymentStatus;

        private string Number;

        public string status
        {
            get { return Status; }
            set { Status = value; }
        }
        public string paymentStatus
        {
            get { return PaymentStatus; }
            set { PaymentStatus = value; }
        }

        public string number
        {
            get { return Number; }
            set { Number = value; }
        }

        public Order() { }
        public Order(string Status, string PaymentStatus, string Number)
        {
            this.Status = Status;
            this.PaymentStatus = PaymentStatus;
            this.Number = Number;
        }
    }
}
