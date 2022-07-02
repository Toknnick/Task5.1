using System;
using System.Collections.Generic;

namespace Task5._1
{
    internal class Program
    {
        static string word = "";
        static bool isWork = true;
        static List<string> listOfStrings = new List<string>();
        static int index = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("exit для выхода.\nЧобы найти слово по индексу введите search the word\n");
            WorkBeforeExit();
        }

        static void WorkBeforeExit()
        {
            while (isWork)
            {
                GetWord();
                SearchTheWord();
                Exit();
                AddWord();
            }
        }

        static string GetWord()
        {
            Console.WriteLine("Введите слово:");
            word = Console.ReadLine().ToLower().Trim();
            return word;
        }

        static void SearchTheWord()
        {
            if (word == "search the word")
            {
                Console.WriteLine("Введите индекс:");
                index = int.Parse(Console.ReadLine()) - 1;

                if (index > listOfStrings.Count || index < 0)
                    Console.WriteLine("Искомого слова нет.");
                else
                    Console.WriteLine(listOfStrings[index]);
            }
        }

        static void AddWord()
        {
            listOfStrings.Add(word);
        }

        static bool Exit()
        {
            if (word == "exit")
                isWork = false;
            return isWork;
        }
    }
}
