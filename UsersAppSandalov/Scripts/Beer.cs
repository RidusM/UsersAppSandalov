using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAppSandalov
{
    class Beer
    {
        [Key]
        public int ID_Beer { get; set; }

        private string Name;

        private string Price, Color_ID, Filter_ID;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string price
        {
            get { return Price; }
            set { Price = value; }
        }

        public string color_ID
        {
            get { return Color_ID; }
            set { Color_ID = value; }
        }
        public string filter_ID
        {
            get { return Filter_ID; }
            set { Filter_ID = value; }
        }

        public Beer() { }
        public Beer(string Name, string Price, string Color_ID, string Filter_ID)
        {
            this.Name = Name;
            this.Price = Price;
            this.Color_ID = Color_ID;
            this.Filter_ID = Filter_ID;
        }
    }
}
