using System;
public class replacing
{
    static void replace(String str, int k)
    {
        String S = "";
        for (int i = 0; i < str.Length; ++i)
        {

            int string_val = str[i];

            int character = k;


            if (string_val + k > 122)
            {
                k -= (122 - string_val);
                k = k % 26;
                S += (char)(96 + k);
            }
            else
            {
                S += (char)(96 + k);
            }

            k = character;
        }

        Console.Write(S);
    }
    public static void Main()
    {
        Console.WriteLine("Enter a string");
        string strs = Console.ReadLine();
        int k = 29;
        replace(strs, k);
    }
}