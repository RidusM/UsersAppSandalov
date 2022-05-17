using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAppSandalov.Scripts
{
    class Client
    {
        [Key]
        public int ID_Client { get; set; }

        private string FullName, TelNumber;

        private string Skidka;

        public string fullName
        {
            get { return FullName; }
            set { FullName = value; }
        }
        public string telNumber
        {
            get { return TelNumber; }
            set { TelNumber = value; }
        }

        public string skidka
        {
            get { return Skidka; }
            set { Skidka = value; }
        }

        public Client() { }
        public Client(string FullName, string TelNumber, string Skidka)
        {
            this.FullName = FullName;
            this.TelNumber = TelNumber;
            this.Skidka = Skidka;
        }
    }
}
