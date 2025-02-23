using System;

using static System.Console;

namespace Twitter_PE2
{
    class Twitter
    {
        static void Main(string[] args)
        {
            String UserPost;

            WriteLine("Write Post");
            UserPost = ReadLine();

            if (UserPost.Length > 140)
                Write("Your message is has too many characters by: " + (UserPost.Length - 140));
            else
                Write("Posted: " + UserPost);


        }
    }
}
