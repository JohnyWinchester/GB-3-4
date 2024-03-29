﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DZ0403AndreyMatveew
{
    /*Матвеев Андрей. Задание 3.
    Дан фрагмент программы:
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
        {"four",4 },
        {"two",2 },
        { "one",1 },
        {"three",3 },
        };
         var d = dict.OrderBy(delegate(KeyValuePair<string,int> pair) { return pair.Value; });
         foreach (var pair in d)
        {
          Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
        }
    а. Свернуть обращение к OrderBy с использованием лямбда-выражения =>.
    b. * Развернуть обращение к OrderBy с использованием делегата.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
            {"four",4 },
            {"two",2 },
            {"one",1 },
            {"three",3 },
            };
            var d = dict.OrderBy(e => e.Value);
            foreach (var pair in d)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
            Console.ReadKey();
        }
    }
}
