using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        public int Id { get; set; }
        private string _Name;
        public string Name
        {
            get { return "Mr. "+ _Name; }
            set { _Name = value; }
        }
        public int LastName { get; set; }
    }
}
