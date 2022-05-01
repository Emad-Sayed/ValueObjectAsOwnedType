using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnTypeDemo.Db.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address AddressOne { get; set; }
        public Address AddressTow { get; set; }
        public List<Hobby> Hobbies { get; set; }

    }
}
