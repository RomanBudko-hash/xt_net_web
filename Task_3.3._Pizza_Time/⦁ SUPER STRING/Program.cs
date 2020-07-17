using System.Text.RegularExpressions;

namespace __SUPER_STRING
{
    public class Program
    {
        static void Main(string[] args)
        {
            string SomeWord = "5sывыв";

            System.Console.WriteLine(SomeWord.WordLanguage());
        }
    }

    public static class Extension
    {
        public static string WordLanguage(this string word)
        {
            int rus = 0, eng = 0, dig = 0;

            if (Regex.IsMatch(word, "[а-яА-ЯеЁ]"))
            {
                rus += 1;
            }
            if (Regex.IsMatch(word, "[a-zA-Z]"))
            {
                eng += 1;
            }
            if (Regex.IsMatch(word, @"[\d\p{Z}]"))
            {
                dig += 1;
            }
            if (rus + eng + dig > 1)
            {
                return "Mixed";
            }

            if (rus == 1)
                return "Russian";
            if (eng == 1)
                return "English";
            if (dig == 1)
                return "Digit";

            return "No one from the variants";
        }
    }
}
