using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stamtræ
{
    class Program
    {
        static void Main(string[] args)
        {
            var relationList = new List<Relation>();
            relationList.Add(new Relation("Erik","Casper"));
            relationList.Add(new Relation("Erik", "Nina"));
            relationList.Add(new Relation("Casper", "Jonathan"));
            relationList.Add(new Relation("Nina", "Sophie"));
            relationList.Add(new Relation("Nina", "Michael"));
            relationList.Add(new Relation("Michael", "Martin"));
            relationList.Add(new Relation("Sophie", "Christian"));
            relationList.Add(new Relation("Anders", "Niels"));
            relationList.Add(new Relation("Peter", "Henrik"));
            relationList.Add(new Relation("Lone", "Peter"));

            var personList =  new List<Person>();
            foreach (var relation in relationList)
            {
                var existingPerson = personList.Find(p=>p.Name == relation.Name);
                if (existingPerson == null)
                { // isnt in list already
                    personList.Add(new Person(relation.Name));
                }
                existingPerson = personList.Find(p => p.Name == relation.ChildName);
                if (existingPerson == null)
                { // isnt in list already
                    personList.Add(new Person(relation.ChildName));
                }
         
            }

            foreach (var relation in relationList)
            {
                var parent = personList.Find(p=>p.Name == relation.Name);
                var child = personList.Find(c=>c.Name == relation.ChildName);
                if (!parent.Kids.Contains(child))
                {
                    parent.Kids.Add(child);
                }
            }

            var gen1 = new List<Person>();
            foreach (var person in personList)
            {
                gen1.Add(person);
                //
            }
            var deleteList = new List<Person>();
             
            foreach (var person in gen1)
            {
                foreach (var pers2 in personList)
                {
                    if (pers2.Kids.Contains(person))
                    {
                        deleteList.Add(person);
                    }
                }
            }
            foreach (var del in deleteList)
            {
                gen1.Remove(del);
            }
        }
    }
}
