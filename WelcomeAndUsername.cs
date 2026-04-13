using System;
using System.Threading;

namespace CyberSecurityChatbot
{//start of namespace
    public class WelcomeAndUsername
    {//start of public class
        public string UserName { get; set; } = string.Empty;

        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("    CYBERSECURITY AWARENESS CHATBOT       ");
            Console.WriteLine("------------------------------------------");
            Console.ResetColor();
        }

        public void AskUser()
        {
            bool isValid = false;
            do
            {
                Console.Write("\nSpaceV: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enter your name to begin");
                Console.ResetColor();
                Console.Write("User: ");

                // Task: String manipulation (Trim)
                UserName = Console.ReadLine()?.Trim();

                // Task 5: Input Validation
                if (!string.IsNullOrEmpty(UserName))
                {
                    isValid = true;
                    TypeResponse($"SpaceV: Hello {UserName}! I am here to help you stay online.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Error] Name cannot be empty.");
                    Console.ResetColor();
                }
            } while (!isValid);

            StartChatLoop();
        }

        private void StartChatLoop()
        {
            while (true)
            {
                Console.Write($"\n{UserName}: ");
                string query = Console.ReadLine()?.ToLower() ?? "";

                if (query == "exit") break;

                //response system

                else if (query.Contains("how are you"))
                    TypeResponse("SpaceV: Good and yourself.");
                else if (query.Contains("password"))
                    TypeResponse("SpaceV: Always use a mix of uppercase, lowercase, numbers, and symbols.");
                else if (query.Contains("purpose"))
                    TypeResponse("SpaceV: I am here to keep you safe online. ");
                else if (query.Contains("phishing"))
                    TypeResponse("SpaceV: Never click links from unknown senders asking for urgent information.");
                else if (query.Contains("browsing"))
                    TypeResponse("SpaceV: Always look for 'HTTPS' in the URL before entering private data.");
                else
                    TypeResponse("SpaceV: I didn't quite understand. Ask me about 'passwords' or 'phishing'.");
            }
        }

        private void TypeResponse(string message)
        {
          //typing colour effect
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }//end of class
}//end of namespace
