using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAppSandalov.Scripts
{
    class Filter
    {
        [Key]
        public int ID_Filter { get; set; }

        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public Filter() { }
        public Filter(string Name)
        {
            this.Name = Name;
        }
    }
}
