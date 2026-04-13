using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CyberSecurityChatBot;


namespace CyberSecurityChatbot
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of method

            // Instance for voice greeting
            Greeting greeting = new Greeting();

            //instance for display logo
            ImageDisplay image = new ImageDisplay();

            // Instance for welcome and username(response system)
            WelcomeAndUsername chat = new WelcomeAndUsername();
            chat.Welcome();
            chat.AskUser();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}