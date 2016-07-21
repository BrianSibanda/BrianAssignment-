using System;

namespace CSharpApplication
{
    public class CSharp
    {
        public static void Main()
        {
            string userName;
           
            Console.Write("Please enter user name: ");
            userName = Console.ReadLine();
            
            Console.WriteLine("Hello {0}.", userName, "welcome back!");
           
        }
    }
}