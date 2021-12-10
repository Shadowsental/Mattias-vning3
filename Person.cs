using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasÖvning3
{
    public class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string fName;
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string lName;
        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Person (int age, string firstName, string lastName, double height, double weight)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Name: {fName} {lName}. Age: {age}. Height: {height}. Weight: {weight}";
        }
    }
}
