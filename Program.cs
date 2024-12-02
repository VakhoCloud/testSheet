// See https://aka.ms/new-console-template for more information

// #1 Sting Methods
// String fullName = "Vakho Cloud";
// String phoneNumber = "598-00-00-00";
// String forTrime = "                Vakho Cloud                  ";

// fullName = fullName.ToUpper();
// fullName = fullName.ToLower();
// Console.WriteLine(fullName);
// phoneNumber = phoneNumber.Replace("-","");

// String username = fullName.Insert(0, "Mr");
// Console.WriteLine(username);

// forTrime = forTrime.Trim();
// Console.WriteLine(phoneNumber + " " + forTrime + " " + username);

// Console.WriteLine(fullName.Length);

// String firstName = fullName.Substring(0, 5);
// String lastName = fullName.Substring(6, 5);

// Console.WriteLine("First name : " + firstName);
// Console.WriteLine("Last name : " + lastName);


// #2 if Statement

// Console.WriteLine("Please enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());

// if(age > 18) 
// {
//     Console.WriteLine("You are signed up!");
// }
// else if(age < 0)
// {
//     Console.WriteLine("You haven't been born yeat");
// }
// else    
// { 
//     Console.WriteLine("You are " + age);
// }


// #3 Arrays
// arrays are fixed size in C#

// String[] cars = {"BMW", "Mustang", "Corvette"};
// foreach (String carItem in cars) {
//     Console.WriteLine(carItem); 
// }
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace TestSheet
{
    class Program {
        static void Main(string[] args) {
            // #4 methods
            // String name = "Vakho";
            // singHappyBirthday(name);


            try {
                Console.WriteLine(CheckOut(5,8,1,0,81,62,50));
            } 
            catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("Finalized");
            }


        }  

        static void singHappyBirthday(String name) {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {name}!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }

        // #5 return, method overload, params
        static double multiply(double x, double y){
            return x * y;
        }
        static double multiply(double x, double y, double z){
            return x * y * z;
        }
        static double CheckOut(params double[] prices) {
            double total = 0;

            foreach(double price in prices) {
                total += price;
            }

            return total;
        }    
    }

}


