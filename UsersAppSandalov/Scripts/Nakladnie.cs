using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAppSandalov.Scripts
{
    class Nakladnie
    {
        [Key]
        public int ID_Nakladnie { get; set; }

        private string Data, DT_Otprav, DT_Pribit;

        private string Price, Order_ID, Worker_ID;

        public string data
        {
            get { return Data; }
            set { Data = value; }
        }
        public string dt_Otprav
        {
            get { return DT_Otprav; }
            set { DT_Otprav = value; }
        }
        public string dt_Pribit
        {
            get { return DT_Pribit; }
            set { DT_Pribit = value; }
        }

        private string price
        {
            get { return Price; }
            set { Price = value; }
        }
        private string order_ID
        {
            get { return Order_ID; }
            set { Order_ID = value; }
        }
        private string worker_ID
        {
            get { return Worker_ID; }
            set { Worker_ID = value; }
        }

        public Nakladnie() { }
        public Nakladnie(string Data, string DT_Otprav, string DT_Pribit, string Price, string Oreder_ID, string Worker_ID )
        {
            this.Data = Data;
            this.DT_Otprav = DT_Otprav;
            this.DT_Pribit = DT_Pribit;
            this.Price = Price;
            this.Order_ID = Oreder_ID;
            this.Worker_ID = Worker_ID;

        }
    }
}
