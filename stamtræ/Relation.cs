using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stamtræ
{
    class Relation
    {
        public string Name { get; set; }
        public string ChildName { get; set; }

        public Relation(string name, string child)
        {
            Name = name;
            ChildName = child;
        }
    }
}
