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
                    Console.WriteLine("Введите индекс искомого слова:");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    if (index > number || index < 0)
                    {
                        Console.WriteLine("Искомого слова нет.");
                    }
                    else
                    {
                        Console.WriteLine("Слово: " + dictionaryOfWords[index]);
                    }
                }

                if (word == "exit")
                    isWork = false;

                dictionaryOfWords.Add(number, word);
                number += 1;
            }
        }
    }
}

