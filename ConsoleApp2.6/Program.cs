using System;

namespace ConsoleApp2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "user";
            string userInput1;
            string userInput2;
            string passWord = "";
            string passWord1;
            string newPassWord;
            
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine(userName + " Добро пожаловать в приложение!\n1-Изменить Имя пользователя\n2-Установить пароль\n3-Изменить пароль\n4-Изменить цвет букв\n5-Изменить размер консоли\n6-выход");
                userInput1 = Console.ReadLine();
                while (!exitApp)
                {
                    switch (userInput1)
                    {
                        case "1":
                            Console.WriteLine("Введите новое имя пользователя");
                            userName = Console.ReadLine();
                            break;

                        case "2":
                            if(passWord == null)
                            {
                                Console.WriteLine("Установить пароль");
                                newPassWord = Console.ReadLine();
                                passWord = newPassWord;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Пароль уже установлен!");                                
                                break;
                            }                           

                        case "3":
                            Console.WriteLine("Для смены пароля введите пароль");
                            passWord1 = Console.ReadLine();
                            if (passWord == passWord1)
                            {
                                Console.WriteLine("Введите новый пароль");
                                newPassWord = Console.ReadLine();
                                passWord = newPassWord;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Неверный пароль");
                                break;
                            }

                        case "4":
                            Console.WriteLine("Выбирите цвет:\n1-Красный\n2-Зеленый\n3-Синий ");
                            userInput2 = (Console.ReadLine());
                            switch (userInput2)
                            {
                                case "1":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Цвет не найден");
                                    break;
                            }
                            break;
                        case "5":
                            Console.WriteLine("Введите пароль");
                            string userInput3 = Console.ReadLine();
                            if (userInput3 == passWord)
                            {
                                Console.WriteLine("Ведите высоту консоли");
                                int height = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ведите ширину консоли");
                                int width = Convert.ToInt32(Console.ReadLine());
                                Console.WindowHeight = height;
                                Console.WindowWidth = width;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Неверный пароль");
                                break;
                            }
                           // break;

                         case "6": 
                            exitApp = true;
                            break;

                        default:
                            Console.WriteLine("Такой команды нет");
                            break;
                    }
                  break;
                }               
            }
        }
    }
}
