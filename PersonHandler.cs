using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasÖvning3
{
    public class PersonHandler
    {
        private List<Person> handler;

        public PersonHandler()
        {
            handler = new List<Person>();
        }
        
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFirstName(Person pers, string firstName)
        {
            pers.FirstName = firstName;
        }

        public void SetLastName(Person pers, string lastName)
        {
            pers.LastName = lastName;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

          
        public Person CreatePerson(int age, string firstName, string lastName, double height, double weight)
        {
                      
            Person person = new Person(age, firstName, lastName, height, weight);
            handler.Add(person);
            return person;
        }

        public List<Person> GetPerson()
        {
            return handler.ToList();
        }
    }
}
