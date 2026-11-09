using System;

public class Class1
{
	public Class1()
	{
	}


    // IsPalindrome function checks if a given string is a palindrome or not
    bool IsPalindrome(string input)
    {
        string reversed = new string(input.Reverse().ToArray());
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);

    }

    Console.WriteLine(IsPalindrome("madam"));

        //classic fizzbuzz 

         for (int i = 1; 1 <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                Console.WriteLine("Buzz");
                }
                else
                {
                Console.WriteLine(i);
                }

            }

   // reverseing the characters in a string 
      static string Reverse(string s)
  {
        char[] chars = s.ToCharArray();
        int left = 0, right = chars.Length - 1;
        while (left < right)
      {
            (chars[left], chars[right]) = (chars[right], chars[left]);
            left++;
         right--;
       }
        return new string(chars);


    }
        Console.WriteLine(Reverse("hello")); //olleh



//counting vowels in a string and counting words in a string

static int CountVowels(string s) =>
            s.Count(c => "aeiouAEIOU".Contains(c));

static int CountWords(string s) =>
 s.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length;


Console.WriteLine(CountVowels("Programming"));
Console.WriteLine(CountWords("I hear there is a party on"));



}
