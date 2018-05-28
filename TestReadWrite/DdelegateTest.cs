using System;

namespace TestDelegate
{
    delegate string StrMod(string str);
    class DelegateTest
    {
        static string ReplaceSpaces(string s)
        {
            Console.WriteLine("Замена пробелов дефисами.");
            return s.Replace(' ', '-');
        }

        static string RemoveSpaces(string s)
        {
            Console.WriteLine("Удаление пробелов.");
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') temp += s[i];
            }
            return temp;
        }

        static void Main(string[] args)
        {
            StrMod strOp = new StrMod(ReplaceSpaces);
            string str;

            str = strOp("Это простой тест.");
            Console.WriteLine(str);
            Console.WriteLine();

            strOp = new StrMod(RemoveSpaces);
            str = strOp("Это простой тест.");
            Console.WriteLine(str);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
