using System;
using System.Collections.Generic;

namespace MattiasÖvning3
{
    internal class Program
    {
        static PersonHandler handler = new PersonHandler();

        static void Main(string[] args)
        {
            bool isOn = true;
            while (isOn == true) { 
                Console.WriteLine("Let's add people to the thing. \n" +
                    "1: Add person. \n" +
                    "2: Check people. \n" +
                    "3: Quit app.");
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddPerson();
                        break;

                    case "2":
                        PrintPeople();
                        break;

                    case "3":
                        isOn = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Input. \n\n");
                        break;
                }
            }
        }

        private static void AddPerson()
        {
            Console.WriteLine("Add a person.");

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            try
            {
                if(age < 1)
                {
                    throw new System.Exception();
                }
                else
                {
                    Console.WriteLine(age);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You can't be younger than 1.");
            }

            Console.Write("First Name: ");
            string firstname = Console.ReadLine();
            try
            {
                if (firstname.Length < 2 || firstname.Length > 10)
                {
                    throw new System.Exception();
                }
                else
                {
                    Console.WriteLine(firstname);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Your first name can't be longer than 10 characters, or shorter than 2 characters.");
            }

            Console.Write("Last Name: ");
            string lastname = Console.ReadLine();
            try
            {
                if (lastname.Length < 3 || lastname.Length > 15)
                {
                    throw new System.Exception();
                }
                else {
                    Console.WriteLine(lastname);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Your last name can't be longer than 15 characters, or shorter than 3 characters.");
            }

            Console.Write("Type in your height in centimeters. (only numbers): ");
            double height = double.Parse(Console.ReadLine());
            try
            {
                if(height < 90 || height > 300)
                {
                    throw new System.Exception();
                }
                else
                {
                    Console.WriteLine(height);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You can't be shorter than 0.90 meters or taller than 3 meters.");
            }

            Console.Write("Type in your weight in kg. (only numbers): ");
            double weight = double.Parse(Console.ReadLine());
            try
            {
                if(weight < 15)
                {
                    throw new System.Exception();
                }
                else
                {
                    Console.WriteLine(weight);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("You can't be lighter than 35kg.");
            }

            handler.CreatePerson(age, firstname, lastname, height, weight);
        }

        private static void PrintPeople()
        {
            var people = handler.GetPerson(); 
            {
                foreach (var pers in people)
                {
                    Console.WriteLine($"{pers}. \n\n");
                }
            }
        }
    }
}
