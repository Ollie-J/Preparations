using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
namespace Testing
{
    class Program
    {

        static int MinList(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return 0;   
            }

            int min = numbers[0];
            foreach(int n in numbers)
            {
                if(n< min)
                {
                    min = n;
                }
            }
            return min;
            Console.WriteLine(MinList(new List<int> { 4, 9, 2, 7 }));
        }

        





       // static bool IsPalindrome(string text)
        //{
           // if(text == null)
           // {
           //     return false;
           // }

           // string reverse = new string(text.Reverse().ToArray());
            //return text.Equals(reversed, StringComparison().OrdinalIgnoreCase);
            
        //}

        public class Person
        {
            public string Name;
            public int Age;
            public bool hasPet;


            public void names()
            {
                Console.WriteLine("my name is " + Name + "age is: " + "Has Pet = " + hasPet);

            }
        }



        static void Main(string[] args)


        {

            // converting input to another data type
            //double a = 3.14;
            // int b = Convert.ToInt32(a);
            // Console.WriteLine(b); // Output: 3
            // Console.WriteLine(a.GetType());

            string[] names = { "john", "emily", "Dave" };
            int[] ages = { 25, 30, 35 };
            string[] email = { "john@email.com", "emily@email.com", "Dave@email.com" };
            int[] passwords = { 12345, 24310, 251 };
            bool[] admins = new bool[3];

            admins[0] = false;
            admins[1] = true;
            admins[2] = false;



            // outputting all names in array 
            //foreach (string name in names)
            //  {
            //        Console.WriteLine(name);
            //}

            for (int i = 0; i < names.Length; i++)
            {


                if (names[i] == "john")
                {
                    int johnAge = ages[2];
                    string johnEmail = email[0];
                    int johnpassword = passwords[2];
                    bool johnAdmin = admins[0];


                }
                else if (names[i] == "emily")
                {
                    int emilyAge = ages[0];
                    string emilyEmail = email[1];
                    int emilypassword = passwords[0];
                    bool emilyAdmin = admins[1];
                }
                else if (names[i] == "Dave")
                {
                    int DaveAge = ages[1];
                    string DaveEmail = email[2];
                    int Davepassword = passwords[1];
                    bool DaveAdmin = admins[0];


                }

                Console.WriteLine($"{names[i]} is {ages[i]},their email is {email[i]}, The Password for this email is {passwords[i]}, ADMIN STATUS: {admins[i]}");
            }



            bool IsPalindrome(string input)
            {
                string reversed = new string(input.Reverse().ToArray());
                return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);

            }
          

            Console.WriteLine(IsPalindrome("Man"));
            Console.WriteLine(IsPalindrome("RacecaR"));

            static int CountVowels(string s) =>
            s.Count(c => "aeiouAEIOU".Contains(c));

            static int CountWords(string s) =>
             s.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length;


            Console.WriteLine(CountVowels("Programming"));
            Console.WriteLine(CountWords("I hear there is a party on"));





            Console.ReadKey();
        }


    }
    class Car
    {
        public string model;
        public Car(string modelName)
        {
            model = modelName;
        }


        static void CarMain(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
        }
       
    }
    
}


