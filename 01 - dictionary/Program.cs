using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> teenSlangDictionary = new Dictionary<string, string>();
            FillTeenSlangDictionary(teenSlangDictionary);

            while (teenSlangDictionary.Any())
            {
                Console.Write("Введите слово: ");
                string userInput = Console.ReadLine();

                if (teenSlangDictionary.ContainsKey(userInput))
                {
                    Console.WriteLine(userInput + teenSlangDictionary[userInput]);                  
                }
                else
                {
                    Console.WriteLine($"Такое слово отсутсвует. Попробуйте ещё раз.");
                }
            }            
        }

        static void FillTeenSlangDictionary(Dictionary<string, string> teenSlangDictionary)
        {            
            teenSlangDictionary.Add("Ауф", "- кайф, круто.");
            teenSlangDictionary.Add("Байтить", "- провоцировать.");
            teenSlangDictionary.Add("Буллинг", "- травля.");
            teenSlangDictionary.Add("Вайб", "- атмосфера.");
            teenSlangDictionary.Add("Варик", "- вариант.");
            teenSlangDictionary.Add("Войсить", "- записывать голосовые сообщения.");
            teenSlangDictionary.Add("Задонатить", "- пожертвовать.");
            teenSlangDictionary.Add("Зашквар", "- что-то позорное.");
            teenSlangDictionary.Add("Изи", "- легко.");
            teenSlangDictionary.Add("Кринж", "- знакомый нам «испанский стыд»..");
            teenSlangDictionary.Add("Криповый", "- пугающий, ужасный.");
            teenSlangDictionary.Add("Личинус ", "- ребёнок.");
            teenSlangDictionary.Add("Овердофига ", "- очень много.");
            teenSlangDictionary.Add("Паль ", "- самая некачественная подделка.");
            teenSlangDictionary.Add("Пранк ", "- розыгрыш, шутка.");
        }
    }
}
