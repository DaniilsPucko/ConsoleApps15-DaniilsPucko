using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        public void DisplayMenu()
        {
            Console.WriteLine("Daniil's News Feed");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Post message");
            Console.WriteLine("2. Post image");
            Console.WriteLine("3. Display All posts");
            Console.WriteLine("4. Quit");
            Console.Write("Type your choice number: ");
            String choice = Console.ReadLine();

            if (choice == "1")
            {

            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {
                DisplayAll();
            }
            else if (choice == "4")
            {

            }

        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            throw new NotImplementedException();
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }
    }
}
