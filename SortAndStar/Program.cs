/*
    You will be given a vector of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.

    The returned value must be a string, and have "***" between each of its letters.

    You should not remove or add elements from/to the array.
*/

public class Kata
{
    static void Main()
    {
        string[] s = new string[] {"who", "take", "over", "the", "world", "maybe", "knows", "bitcoin", "perhaps"};
        
        System.Console.WriteLine(TwoSort(s));
    }

    public static string TwoSort(string[] s)
    {
        string finalOutput = "";
        Array.Sort(s);
        char[] output = s[0].ToCharArray();
        for (int i = 0; i < output.Length; i++)
        {
            finalOutput += output[i] + "***";
        }
        
        string test = finalOutput.Substring(0,finalOutput.Length - 3);
        
        return test;
    }  
}