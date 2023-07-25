using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace again
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();
            if(password == "love")
            {
                System.Console.WriteLine("I love you too");
            }
            else
            {                               
                for(int i=0; i<3 || password != "love"; i++)
                {
                    System.Console.WriteLine("enter again");
                    string newpassword = Console.ReadLine();
                        if(newpassword == "love")
                        {
                            System.Console.WriteLine("I love you too");
                            break;
                        }
                }
                
            }
            System.Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Nice  to meet you " + name);
        }
    }
}