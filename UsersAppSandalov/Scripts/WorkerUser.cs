using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite.EF6.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace UsersAppSandalov
{
    class WorkerUser 
    {

        [Key] 
        public int ID_Worker { get; set; }

        private string Login, Pass, FullName, Obrazovanie, Graph;

        private string Payment;

        public string payment
        {
            get { return Payment; }
            set { Payment = value; }
        }
        public string fullName
        {
            get { return FullName; }
            set { FullName = value; }
        }

        public string obrazovanie
        {
            get { return Obrazovanie; }
            set { Obrazovanie = value; }
        }
        public string graph
        {
            get { return Graph; }
            set { Graph = value; }
        }
        public string login 
        {
            get { return Login; }
            set { Login = value; }
        }
        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }

        public WorkerUser() { }
        public WorkerUser(string Login, string Pass, string FullName, string Obrazovanie, string Graph, string Payment)
        {
            this.Login = Login;
            this.Pass = Pass;
            this.FullName = FullName;
            this.Obrazovanie = Obrazovanie;
            this.Graph = Graph;
            this.Payment = Payment;
        }
    }
}
