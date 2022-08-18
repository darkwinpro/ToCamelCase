
//Complete the method/function so that it converts dash/underscore delimited words into camel casing.
//The first word within the output should be capitalized only if the original word was capitalized
//(known as Upper Camel Case, also often referred to as Pascal case).
//
//Examples
//"the-stealth-warrior" gets converted to "theStealthWarrior"
//"The_Stealth_Warrior" gets converted to "TheStealthWarrior"
public class Kata
{
    public static string ToCamelCase(string str)
    {
        string resultString = String.Empty;
        string[] words = str.Split(new[] {'-', '_'});
        
        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];
            if (i != 0)
            { 
                word = word.Substring(0, 1).ToUpper() + word.Substring(1);
            }
            resultString += word;
        }

        return resultString;
    }
}
internal class Program
{
    public static void Main(string[] args)
    {
        string cellNumber = Kata.ToCamelCase("the_Stealth_Warrior");
        Console.WriteLine(cellNumber);
    }
}