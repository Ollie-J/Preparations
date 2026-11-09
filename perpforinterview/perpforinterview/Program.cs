using System;
using System.Collections.Generic;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // converting input to another data type
            //double a = 3.14;
            // int b = Convert.ToInt32(a);
            // Console.WriteLine(b); // Output: 3
            // Console.WriteLine(a.GetType());

            string[] names = { "john", "emily", "Dave" };
            int[] ages = { 25, 30, 35 };
            string[] email = { "john@email,com", "emily@email.com", "Dave@email.com" };

            // outputting all names in array 
            //foreach (string name in names)
              //  {
            //        Console.WriteLine(name);
            //}

           for(int i = 0; i < names.Length; i++)
            {
                if (names[i] == "john")
                {
                    string johnEmail = email[0];
                    int johnAge = ages[2];
                }else if (names[i] == "emily")
                {
                    string emilyEmail = email[1];
                    int emilyAge = ages[0];
                }else if (names[i] == "Dave")
                {
                    string DaveEmail = email[2];
                    int DaveAge = ages[1];
                }

                Console.WriteLine($"{names[i]} is {ages[i]},their email is {email[i]}");
            }

          

            bool IsPalindrome(string input)
            {
                string reversed = new string(input.Reverse().ToArray());
                return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);

            }

            Console.WriteLine(IsPalindrome("Man"));

            static int CountVowels(string s) =>
            s.Count(c => "aeiouAEIOU".Contains(c));

            static int CountWords(string s) =>
             s.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length;


            Console.WriteLine(CountVowels("Programming"));
            Console.WriteLine(CountWords("I hear there is a party on"));

            Console.ReadKey();
       }


    }
        

}