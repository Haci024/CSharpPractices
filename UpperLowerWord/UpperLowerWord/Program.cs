using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "Odissey";
        string newWord = "";

        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsUpper(word[i]))
            {
                newWord += char.ToLower(word[i]);
            }
           
            else
            {
                newWord += char.ToUpper(word[i]);
            }

        }

        Console.WriteLine(newWord);
    }
}
