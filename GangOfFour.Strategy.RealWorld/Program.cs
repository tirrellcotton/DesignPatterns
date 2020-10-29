﻿using System;
using System.Collections.Generic;

namespace GangOfFour.Strategy.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Strategy Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main(string[] args)
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();
 
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");
 
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
 
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
 
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
 
            // Wait for user
            Console.ReadKey();
        }
    }
}