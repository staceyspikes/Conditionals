using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your age");

            //int age = int.Parse(Console.ReadLine());

            //if (age >= 17)
            //{
            //    Console.WriteLine("You can see this movie");
            //}

            //if (age == 18)
            //{
            //    Console.WriteLine("You are now an adult");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry you are too young you need a parent present");

            //}


            //Console.WriteLine("Enter your percentage");
            //int grade = int.Parse(Console.ReadLine());
            //if(grade >= 90 && grade <= 100)
            //{
            //    Console.WriteLine("You got an A!!");
            //}
            //else if(grade >= 80 && grade <= 89)
            //{
            //    Console.WriteLine(" You got a B!");
            //}

         


            //Console.WriteLine("How much is your total bill?");
            //double totalBill = double.Parse(Console.ReadLine());
            //if (totalBill >= 50)
            //{
            //    Console.WriteLine("You earned 10% off your bill");
            //}
            //else
            //{
            //    Console.WriteLine("You earned 5% off your bill");
            //}
            //Console.WriteLine("Your new total is");
            //if (totalBill >= 50)
            //{
            //    Console.WriteLine(totalBill * .90);
            //}
            //else
            //{
            //    Console.WriteLine(totalBill * .95);
            //}
            //Console.WriteLine("How many people are in your group?");
            //int peopleGroup = int.Parse(Console.ReadLine());

            //Console.WriteLine("Each person owes the following amount");
            //if (totalBill >= 50)
            //{
            //    Console.WriteLine((totalBill * .90) / peopleGroup);
            //}
            //else
            //{
            //    Console.WriteLine((totalBill * .95) / peopleGroup);
            //}


            Console.WriteLine(" What is your age?");
            int age = int.Parse(Console.ReadLine());
            if (age <=2 && age >= 0)
            {
                Console.WriteLine("Still in mamas arms");
            }
            if(age >= 3 && age<=4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            if (age >= 5 && age <=11)
            {
                Console.WriteLine("Elementary School");
            }
            if (age >=12 && age <=14)
            {
                Console.WriteLine("Middle School");
            }
            if (age >=15 && age <=18)
            {
                Console.WriteLine("High School");
            }
            if (age >= 19 && age <=22)
            {
                Console.WriteLine(" College");
            }
            if (age >= 23 && age <=65)
            {
                Console.WriteLine("Working for the man");
            }
            if (age >=66 && age <=100)
            {
                Console.WriteLine("The Golden Years");
            }
            if (age <0)
            {
                Console.WriteLine(" This program is for humans");
            }
            if (age>100)
            {
                Console.WriteLine(" This program is for humans");
            }



        }
    }
}
