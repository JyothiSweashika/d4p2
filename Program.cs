﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] studmarks = new int[4, 5]
        {
            { 1, 80, 85, 90, 95 },
            { 2, 75, 70, 85, 80 },
            { 3, 90, 92, 88, 95 },
            { 4, 70, 65, 75, 80 }
        };

            
            Console.WriteLine("RollNo sem1 sem2 sem3 sem4 Total");

           
            for (int i = 0; i < 4; i++)
            {
                int rollNo = studmarks[i, 0];
                int sem1 = studmarks[i, 1];
                int sem2 = studmarks[i, 2];
                int sem3 = studmarks[i, 3];
                int sem4 = studmarks[i, 4];
                int total = sem1 + sem2 + sem3 + sem4;

              
                Console.WriteLine($"{rollNo,-6} {sem1,-5} {sem2,-5} {sem3,-5} {sem4,-5} {total,-5}");
            }

            Console.ReadKey();
        }
    }
}
