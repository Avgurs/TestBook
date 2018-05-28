using System;

namespace TestDelegate
{
    delegate void StrMod(ref string str);
    class MultiCastDemo
    {
        static void ReplaceSpaces(ref string s)
        {
            Console.WriteLine("Замена символов т-Т.");
            s = s.Replace('т', 'Т');
        }

        static void RemoveSpaces(ref string s)
        {
            Console.WriteLine("Удаление пробелов.");
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') temp += s[i];
            }
            s = temp;
        }

        static void Main(string[] args)
        {
            StrMod strOp;
            StrMod replaceSp = ReplaceSpaces;
            StrMod removeSp = RemoveSpaces;
            string str = "Это простой тест.";

            strOp = replaceSp;
            strOp += removeSp;

            strOp(ref str);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
