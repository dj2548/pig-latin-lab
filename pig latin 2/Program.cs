using System;
        

     internal class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FindVowelPosition("hello"));
        Console.WriteLine(FindVowelPosition("sky"));
        Console.WriteLine(FindVowelPosition("strong"));
        Console.WriteLine(FindVowelPosition("apple"));

    }



    //Containsvowel
    //IsVowel(char c)

    //FindVowelPosition()

    public static bool Isvowel(char c) 
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
       
        bool isvowels = vowels.Contains(c);
        
        return isvowels;
    }

    public static int FindVowelPosition(string word) 
    {
    for(int i = 0; i < word.Length; i++)
        {
            char c = word[i];
            bool isvowel = IsVowel(c);
            if(isVowel == true) 
            {
                return i;
            }
        }
    return -1;
    }










}