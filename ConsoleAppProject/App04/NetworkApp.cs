using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    class NetworkApp
    {
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

            bool wantToQuit = false;
            do
            {
                if (choice == "1")
                {

                }
                else if (choice == "2")
                {

                }
                else if (choice == "3")
                {

                }
                else if (choice == "4")
                {
                    wantToQuit = true;
                }
            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            throw new NotImplementedException();
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
