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
    class Slkad
    {
        [Key]
        public int ID_Sklad { get; set; }

        private string Mesto;

        private string Pivo_ID;

        public string pivo_ID
        {
            get { return Pivo_ID; }
            set { Pivo_ID = value; }
        }
        public string mesto
        {
            get { return Mesto; }
            set { Mesto = value; }
        }

        public Slkad() { }
        public Slkad(string Mesto, string Pivo_ID)
        {
            this.Mesto = Mesto;
            this.Pivo_ID = Pivo_ID;
        }

    }
}
