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
            Console.WriteLine("4. Remove Post");
            Console.WriteLine("5. Display by Author");
            Console.WriteLine("6. Display by Date");
            Console.WriteLine("7. Add Comment");
            Console.WriteLine("8. Like post");
            Console.WriteLine("9. Quit");
            Console.Write("Type your choice number: ");
            String choice = Console.ReadLine();

            if (choice == "1")
            {
                PostMessage();
            }
            else if (choice == "2")
            {
                PostImage();
            }
            else if (choice == "3")
            {
                DisplayAll();
            }
            else if (choice == "4")
            {
                RemovePost();
            }

        }

        private void DisplayAll()
        {
            Console.WriteLine("Displaying all posts...");
            news.Display();
            DisplayMenu();
        }

        private void PostImage()
        {
            Console.WriteLine("Posting an Image...");

            Console.Write("Type your username: ");
            string author = Console.ReadLine();

            Console.Write("Please enter your image filename: ");
            string filename = Console.ReadLine();

            Console.Write("Please enter your image caption: ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            Console.WriteLine("You have succesfully posted a photo.");
            post.Display();

            DisplayMenu();
        }

        private void PostMessage()
        {
            Console.WriteLine("Posting a message...");
            
            Console.Write("Type your username: ");
            string author = Console.ReadLine();

            Console.Write("Please enter your message: ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            Console.WriteLine("You have succesfully posted a message.");
            post.Display();

            DisplayMenu();
        }

        private void RemovePost()
        {
            Console.WriteLine("Removing a post...");
            Console.Write("Please enter your post id: ");
            string value = Console.ReadLine();
            int id = Convert.ToInt32(value);

            news.RemovePost(id);
            DisplayMenu();
        }

        private void DisplayByAuthor()
        {
            Console.WriteLine("Displaying authors posts...");
            Console.Write("Please enter authors username: ");
            string username = Console.ReadLine();

            news.DisplayAuthor(username);
        }
    }
}
