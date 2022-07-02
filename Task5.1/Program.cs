using System;
using System.Collections.Generic;

namespace Task5._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool isWork = true;
            Dictionary<int, string> dictionaryOfWords = new Dictionary<int, string>();
            Console.WriteLine("exit для выхода.\nЧобы найти слово по индексу введите search. \n");
            int number = 0;

            while (isWork)
            {
                Console.WriteLine("Введите слово:");
                string word = Console.ReadLine().ToLower().Trim();

                if (word == "search")
                {
                    Console.WriteLine("Введите ключ искомого слова:");
                    int keyOfDictionary = int.Parse(Console.ReadLine()) - 1;

                    if (!dictionaryOfWords.ContainsKey(keyOfDictionary))
                        Console.WriteLine("Искомого слова нет.");
                    else
                        Console.WriteLine("Слово: " + dictionaryOfWords[keyOfDictionary]);
                }

                if (word == "exit")
                    isWork = false;

                if (!dictionaryOfWords.ContainsValue(word))
                    dictionaryOfWords.Add(number, word);
                else
                    Console.WriteLine("Такое слово уже есть");

                number += 1;
            }
        }
    }
}

