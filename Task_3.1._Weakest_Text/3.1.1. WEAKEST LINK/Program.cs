﻿using System;

namespace _3._1._1.WEAKEST_LINK
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logic play = new Logic();

            while (true)
            {
                Console.WriteLine("Please, enter count of people");

                if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
                {
                    Console.WriteLine("Please, enter number cross out a person");

                    if (int.TryParse(Console.ReadLine(), out int y) && y > 0)
                    {
                        play.PeopleCrossOut(x, y);
                    }
                }
            }
        }
    }
}
