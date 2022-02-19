using System;
namespace Day16Project4
{
    class Palindrome
    {
        int input;
       
        public int ReadInput()
        {
            Console.Write("Enter Any Number ");
            input = int.Parse(Console.ReadLine());
            return input;
        }
       public bool IsPalindrome()
        {
            int rev = 0, rem, m;
            m = input;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (input == rev)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Object
            Palindrome p = new Palindrome();
            int input = p.ReadInput();     // Calling ReadInput()
            bool isPalindrome = p.IsPalindrome(); // Calling IsPalindrome() 
            if (isPalindrome == true)
                Console.WriteLine("Yes, {0} Is a Palindrome Number", input);
            else
                Console.WriteLine("No, {0} is Not a Palindrome Number", input);

            Console.ReadLine();
        }
    }
}
