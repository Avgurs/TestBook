using System;

namespace TestDelegate
{
    delegate string StrMod(string str);
    class UseStatementLambdas
    {
        //Тест Lambda

        static void Main(string[] args)
        {
            StrMod ReplaceSpaces = NewMethod();

            StrMod RemoveSpaces = s =>
            {
                Console.WriteLine("Удаление пробелов.");
                string temp = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ') temp += s[i];
                }
                return temp;
            };

            StrMod strOp = RemoveSpaces;
            string str;

            str = strOp("Это простой тест.");
            Console.WriteLine(str);
            Console.WriteLine();

            strOp = ReplaceSpaces;
            str = strOp("Это простой тест.");
            Console.WriteLine(str);
            Console.WriteLine();

            Console.ReadKey();

        }

        private static StrMod NewMethod()
        {
            return s =>
            {
                Console.WriteLine("Замена пробелов дефисами.");
                return s.Replace(' ', '-');
            };
        }
    }
}
