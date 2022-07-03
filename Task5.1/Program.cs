uusing System;
using System.Collections.Generic;

namespace Task5._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("Россия", "Столица - Москва");
            countries.Add("США", "Столица - Вашингтон");
            countries.Add("Китай", "Столица - Пекин");
            countries.Add("Япония", "Столица - Токио");
            countries.Add("Канада", "Столица - Отта́ва ");

            Console.WriteLine("Введите названи страны:");
            string word = Console.ReadLine().Trim();

            if (countries.ContainsKey(word))
            {
                Console.WriteLine(countries[word]);
            }
            else
            {
                Console.WriteLine("Такого слова нет!");
            }
        }
    }
}
