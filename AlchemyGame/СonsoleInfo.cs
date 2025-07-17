using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyGame
{
    internal class СonsoleInfo
    {
        public void PrintMenu(params string[] ConsolePrint)
        {
            
            Console.WriteLine("Добро пожаловать в игру 'Алхимия'!");
            Console.WriteLine("Цель игры собрать элементы всех разрядов. Изначально у вас есть 4 основных элементов. \nЭто огонь, вода, воздух и земля, но вы можете получить элементы второго разряда.");
            Console.WriteLine("Ниже перечислен список доступных действий: ");
            for (int i = 0; i < ConsolePrint.Length; i++) 
            {
                Console.WriteLine($"{i+1}. {ConsolePrint[i]}");
            }
        }
        public void BasePrint(params string[] ConsolePrint)
        {
            for (int i = 0; i < ConsolePrint.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {ConsolePrint[i]}");
            }
        }
        public void AddedNewElement(string ElementName)
            { Console.WriteLine("Вы получили новый элемент, под названием: " + ElementName); }
        public string[] AllElements = new string[6];
        public void PrintAllElements()
        {
            for (int i = 0; i < AllElements.Length; i++)
            {
                Console.WriteLine($"{i+1}. {AllElements[i]}");
            }
        }
    }
}
