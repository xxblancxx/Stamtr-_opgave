using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stamtræ
{
    class Person
    {

        public string Name { get; set; }
    
        public List<Person> Kids { get; set; }

        public Person(string name)
        {
            
            Name = name;
            Kids = new List<Person>();
        }
    }
}
