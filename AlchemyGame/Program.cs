using System;
using System.Globalization;
using System.Security;
using AlchemyGame;

namespace AlchemyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunningGame = true;
            bool RunningCase1 = true;
            bool RunningCase2 = true;
            GettingData gettingData = new GettingData();
            СonsoleInfo consoleInfo = new СonsoleInfo();
            consoleInfo.PrintMenu("Перейти к смешиванию элементов", "Посмотреть список открытых элементов", "Завершить игру");
            while (RunningGame)
            {
                gettingData.PlayerValue = Console.ReadLine();
                switch (gettingData.PlayerValue)
                {
                    case "1":
                        Console.WriteLine("Вы перешли в смешивание. Тут как понятно из названия вы можете смешивать элементы." +
                            "\nДля того, чтобы выйти из режима смешивания элементов введите 0." +
                            "\nДля того, чтобы смешать два элемента просто введите цифры, которые слева от названия элемента. " +
                            "\nНапример 12 или 21 смешает Огонь и Воду или Воду и Огонь, но результат один. " +
                            "\nСписок доступных элементов:");
                        consoleInfo.BasePrint("Огонь", "Вода", "Воздух", "Земля");
                        RunningCase1 = true;
                        while (RunningCase1)
                        {
                            gettingData.PlayerValueCase1 = Console.ReadLine();
                            switch (gettingData.PlayerValueCase1)
                            { 
                                case "12":
                                case "21":
                                    consoleInfo.AddedNewElement("Пар");
                                    consoleInfo.AllElements[0] = "Пар";
                                    break;
                                case "13": 
                                case "31":
                                    consoleInfo.AddedNewElement("Дым");
                                    consoleInfo.AllElements[1] = "Дым";
                                    break;
                                case "14":
                                case "41":
                                    consoleInfo.AddedNewElement("Магма");
                                    consoleInfo.AllElements[2] = "Магма";
                                    break;
                                case "23":
                                case "32":
                                    consoleInfo.AddedNewElement("Дождь");
                                    consoleInfo.AllElements[3] = "Дождь";
                                    break;
                                case "24":
                                case "42":
                                    consoleInfo.AddedNewElement("Грязь");
                                    consoleInfo.AllElements[4] = "Грязь";
                                    break;
                                case "43":
                                case "34":
                                    consoleInfo.AddedNewElement("Пыль");
                                    consoleInfo.AllElements[5] = "Пыль";
                                    break;
                                case "0":
                                    Console.WriteLine("Вы выходите из режима смешивания");
                                    RunningCase1 = false;
                                    break;
                                default:
                                    Console.WriteLine("Нет такой комбинации");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ниже будет представлен список открытых элементов: ");
                        consoleInfo.PrintAllElements();
                        Console.WriteLine("Чтобы выйти из библиотеки открытых элементов, введите 0");
                        RunningCase2 = true;
                        while (RunningCase2)
                        {
                            string ValueForCase2 = Console.ReadLine();
                            switch (ValueForCase2)
                            {
                                case "0":
                                    Console.WriteLine("Вы выходите из библиотеки элементов");
                                    RunningCase2 = false;
                                    break;
                                default: 
                                    Console.WriteLine("Неизвестная команда");
                                    break;
                            }
                        }
                        break;
                    case "0":
                        Console.WriteLine("Игра завершена");
                        RunningGame = false;
                        break;
                    default:
                        Console.WriteLine("Я не могу такое сделать");
                        break;
                }
            }
        }
    }
}