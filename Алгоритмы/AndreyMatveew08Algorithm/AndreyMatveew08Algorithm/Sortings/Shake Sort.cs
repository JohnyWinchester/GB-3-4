﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveew08Algorithm.Sortings
{
    public class Shake_Sort
    {
        public static long[] Shake(int[] hundredArr, int[] tenThousandArr, int[] millionArr)
        {
            long[] times = new long[3];
            times[0] = TimeCalculating(hundredArr);
            times[1] = TimeCalculating(tenThousandArr);
            times[2] = TimeCalculating(millionArr);

            return times;
        }
        private static long TimeCalculating(int[] arr)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            var sortArr = ShakerSort(arr);
            stopwatch.Stop();

            Console.WriteLine($"{stopwatch.Elapsed.Milliseconds}  {stopwatch.Elapsed.Seconds}");
            return stopwatch.Elapsed.Milliseconds;
        }
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        static int[] ShakerSort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }
                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }
            return array;
        }
    }
}
