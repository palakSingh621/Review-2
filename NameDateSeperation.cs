using System;
namespace Review_2
{
    internal class NameDateSeperation
    {
        static void Main(string[] args)
        {
            string s = "Hii I am Palak13/01/24";
            //Console.WriteLine("Enter your Name: ");
            //String name = Console.ReadLine();
            s = s.Trim();
            s = s + " ";
            string word = "";
            string longestWord = "";
            int maxLength = 0;
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    if (word.Length > maxLength)
                    {
                        maxLength = word.Length;
                        longestWord = word;
                    }
                    word = "";
                }
                else
                {
                    word += c;
                }
            }
            int length = longestWord.Length;
            string date = "";
            string name = "";
            for (int i = 0; i < length; i++)
            {
                if (char.IsDigit(longestWord[i]))
                {
                    for (int j = 0; j < i; j++)
                    {
                        name += longestWord[j];
                    }
                    for (int j = i; j < length; j++)
                    {
                        date += longestWord[j];
                    }
                    break;
                }
            }
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Date: " + date);
        }
    }
}
