using System;

public class Class1
{
	public Class1()
	{
	}

    static bool IsPalindromes(string text)
    {
        text = text.ToLower();

        for (int i = 0; i <= text.Length; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
            { 
                return false;
            }
        }
        return true;
    }

    // IsPalindrome function checks if a given string is a palindrome or not
    bool IsPalindrome(string input)
    {
        if(input == null)
        {
            return false;
        }
        string reversed = new string(input.Reverse().ToArray());
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);

    }

   // Console.WriteLine(IsPalindrome("madam"));

        //classic fizzbuzz 

        // for (int i = 1; 1 <= 100; i++)
       //     {
          //      if (i % 15 == 0)
         //       {
               //     Console.WriteLine("FizzBuzz");
         //       }
          //      else if (i % 3 == 0)
          //      {
         //       Console.WriteLine("Fizz");
           //     }
           //     else if (i % 5 == 0)
           //     {
           //     Console.WriteLine("Buzz");
        //        }
         //       else
         //       {
         //       Console.WriteLine(i);
         //       }

        //    }

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
      //  Console.WriteLine(Reverse("hello")); //olleh



//counting vowels in a string and counting words in a string

static int CountVowels(string s) =>
            s.Count(c => "aeiouAEIOU".Contains(c));

static int CountWords(string s) =>
 s.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length;


    //Console.WriteLine(CountVowels("Programming"));
    //Console.WriteLine(CountWords("I hear there is a party on"));


    //  public class person
    // {
    //    public string Name;
    //   public int Age;
    //   public bool hasPet;


    //   public void names()
    //    {
    //       Console.WriteLine("my name is " + Name + "age is: " + "Has Pet = " + hasPet);

    //   }
    //  }

    // in the program class write the following as it will run when built

    //person person = new person();
    //person.Name = "Dave";
    // person.Age = 24;
    // person.hasPet = true;

    //person.names();

   // public class car
    //{

     //   public string model;

     //   public car()
     //   {
      //      model = focus;

     //   }

     //   static void Main(string[] args)
     //   {
      //      car Ford = new car();
     //       Console.WriteLine(Ford.model);
     //   }



   // }
}


