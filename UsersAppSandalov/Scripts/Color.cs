using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAppSandalov.Scripts
{
    class Color
    {
        [Key]
        public int ID_Color { get; set; }

        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public Color() { }
        public Color(string Name)
        {
            this.Name = Name;
        }
    }
}
