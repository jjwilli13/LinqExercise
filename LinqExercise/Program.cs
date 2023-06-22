using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of numbers:");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("----------------");

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of Numbers");
            Console.WriteLine(numbers.Average());
            Console.WriteLine("----------------");

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers by Ascending");
            var orderbyAscending = numbers.OrderBy(number => number);
            foreach (var nums in orderbyAscending)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine("----------------");

            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Numbers by Descending");
            var orderbyDescending = numbers.OrderByDescending(number => number);
            foreach (var number in orderbyDescending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("----------------");

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers Greater Than 6");
            var numsGreaterthan6 = numbers.Where(number => number > 6);
            foreach (var numnum in numsGreaterthan6)
            {
                Console.WriteLine(numnum);
            }
            Console.WriteLine("----------------");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Numbers Take 4");
            foreach (var num in orderbyAscending.Take(4))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("----------------");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Descending with my Age");
            numbers[4] = 32;
            foreach (var num in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("----------------");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Employees with C or S First Name:");
            var employee = employees.Where(employer => employer.FirstName.StartsWith('C') || (employer.FirstName.StartsWith('S')))
                                    .OrderBy(employer => employer.FirstName);

            foreach (var name in employee)
            {
                Console.WriteLine(name.FullName);
            }
            Console.WriteLine("----------------");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Over Twenty Six:");
            var overTwentySix = employees.Where(employer => employer.Age > 26).OrderBy(employer => employer.Age)
                                    .ThenBy(employer => employer.FirstName);
            foreach (var name in overTwentySix)
            {

                Console.WriteLine($"Full Name: {name.FullName} Age: {name.Age}");
         
            }
            Console.WriteLine("----------------");

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var years = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35);

            Console.WriteLine($"Total Years of Experiencee: {years.Sum(employer => employer.YearsOfExperience)}");
            Console.WriteLine($"Average Years of Experiencee: {years.Average(employer => employer.YearsOfExperience)}");

            Console.WriteLine("----------------");

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("Jordan", "Williams", 32, 2)).ToList();

            foreach (var employer in employees)
            {
                Console.WriteLine($"{employer.FirstName} {employer.Age}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        private static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
