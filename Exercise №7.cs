using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            string text = "Я люблю кушать пельмени";
            string[] wordsFromText = text.Split(' ');

            foreach (string word in wordsFromText)
                Console.WriteLine(word);
        }
    }
}
