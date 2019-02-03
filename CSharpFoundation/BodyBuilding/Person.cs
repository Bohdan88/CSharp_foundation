using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFoundation.BodyBuilding
{
    public class Person
    {

        // declare data about person
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public string fullName { get { return firstName + " " + lastName; } }
        public int age { get; private set; }




        public Person(string _firstName = "", string _lastName = "", int _age = 0)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.age = _age;
        }

        // Fill out data
        public void WriteData()
        {
            Console.WriteLine("Write your name");
            this.firstName = Console.ReadLine();

            if (this.firstName != "")
            {
                Console.WriteLine("Your surname");
                this.lastName = Console.ReadLine();
            }

            if (this.lastName != "")
            {
                Console.WriteLine("Your age");
                this.age = Convert.ToInt32(Console.ReadLine());

            }
            if (this.age > 0)
            {
                Console.Clear();

                Console.WriteLine(" First name: " + firstName + "\n Family name: " + fullName + " \n Your age: " + age);
                IBM();

            }

            else if (this.age <= 0)
            {
                Console.WriteLine("It is impossible!");
            }
        }

      
        // Calculate Body index
        public void IBM()
        {
            double height, weight;
            Console.WriteLine("Write your weight in kg");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write your height in cm");
            weight = Convert.ToDouble(Console.ReadLine());

            double result = 703 * (weight / (height * height));

            if (result > 2 && result <= 15)
            {
                Console.WriteLine("\nYour BMI is " + Math.Round(result, 2) + " \n\n " + firstName + ",  you are underweight");
            }
            else if (result > 15 && result < 25)
            {
                Console.WriteLine("\n Your BMI is " + Math.Round(result, 2) + " \n\n " + firstName + ", your weight is normal");
            }
            else if (result > 25 && result < 50)
            {
                Console.WriteLine("\n Your BMI is " + Math.Round(result, 2) + " \n\n " + firstName + ", you are obese");
            }

            else if (result < 0 || result > 50)
            {
                Console.WriteLine("You wrote invalid data, rewrite please!");
            }
        }



        // greeting function
        public string Greeting(string name)
        {
            // validation 
            if (string.IsNullOrEmpty(this.firstName) || string.IsNullOrWhiteSpace(this.firstName))
                  {
                       throw new ArgumentException();
                       }
                return "Hello, " + name;
        }
        // method overload
        public string Greeting(Person person)
        {
            if (person == null)
            {
                // validation
                throw new ArgumentException("person can`t be null");

            }
            else
            {
                return "Hello, " + person.fullName;
            }
        }



    }
}
