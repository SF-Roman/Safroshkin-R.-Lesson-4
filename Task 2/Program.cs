using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{

    /// <summary>
    /// Задача 4
    /// Сафрошкин Роман
    /// </summary>
    class Program
    {

        struct Account
        {
            public string Login;
            public string Password;

            public void readFile(string filename)
            {
                filename = "..\\..\\" + filename;
                StreamReader data = new StreamReader(filename);

                Login = data.ReadLine();

                Password = data.ReadLine();

                data.Close();
            }

        }

        static bool logIN(Account check)
        {
            if (check.Login == "root" && check.Password == "GeekBrains")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в GeekBrains. Эта программа считает ваш логин и пароль из файла");
            int tryCount = 3;

            string[] fileName = { "data.txt"};

            Account account;
            account.Login = "";
            account.Password = "";

            int i = 0;

            do
            {
                Console.WriteLine("\nЗагружаем файл с вашими данными: " + fileName[i]);
                account.readFile(fileName[i]);

                Console.Write("\nРезультат авторизации: ");

                if (logIN(account))
                {

                    break;
                }
                else
                {
                    tryCount--;
                    Console.WriteLine("Неверный ввод логина или пароля." +
                    Environment.NewLine + "У Вас осталось " + tryCount);
                }
                i++;
            } while (tryCount > 0);

            Console.Write("Авторизация успешна!");

            Console.ReadKey();
        }
    }
}
