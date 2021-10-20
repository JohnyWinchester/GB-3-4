﻿using System;

namespace DZ0502AndreyMatveew
{
    /* Матвеев Андрей. Задача 2. 
    Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    а) Вывести только те слова сообщения,  которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    д) ***Создать метод, который производит частотный анализ текста.
    В качестве параметра в него передается массив слов и текст, 
    в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    Здесь требуется использовать класс Dictionary.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести только те слова сообщения, которые содержат не более n букв: ");
            Message.AmountLetters("три четыре пять десять Дратуйте", 4);

            Console.WriteLine("\nУдалить из сообщения все слова, которые заканчиваются на заданный символ: "
                              + Message.DeleteLetters("три четыре пять десять Дратуйте", 'ь'));

            Console.WriteLine("\nНайти самое длинное слово сообщения: "
                              + Message.MostLongLetter("три четыре пять десять Дратуйте"));

            Console.WriteLine("\nСформировать строку с помощью StringBuilder из самых длинных слов сообщения: "
                              + Message.MostLongLetters("три четыре пять десять Дратуйте"));

            Console.WriteLine("\nСоздать метод, который производит частотный анализ текста: ");
            var textAnalysis = Message.FrequencyAnalysis("три четыре три четыре пять три пять привет привет привет");
            foreach(var el in textAnalysis)
            {
                Console.WriteLine(el.Key + " - " + el.Value);
            }

            Console.ReadKey();
        }
    }
}
