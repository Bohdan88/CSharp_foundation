using System;

namespace CSharpFoundation.BodyBuilding
{
    class MainClass
    {
        public static void Main(string[] args)
        {




            Console.WriteLine("In order to calculate your Body Mass Index fill out data below  :)\n");
            Person person = new Person();
           person.WriteData();
            Console.WriteLine();
                        Console.ReadLine();
        }

       
    }
}
