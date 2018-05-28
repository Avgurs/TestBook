using System;
using System.IO;


namespace TestReadWrite
{
    class Redirect
    {
        static void Main(string[] args)
        {

            StreamWriter log_out = null;
            try
            {
                log_out = new StreamWriter("logfile.txt");
                Console.SetOut(log_out);

                Console.WriteLine("Начало файла");

                for (int count = 0; count < 10; count++)
                    Console.WriteLine("Count {0}", count);

                Console.WriteLine("End of file");

            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода файла\n" + exc.Message);
            }
            finally
            {
                if (log_out != null) log_out.Close();
            }
        }
    }
}
