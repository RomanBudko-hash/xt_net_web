using System;

namespace _3._1._1.WEAKEST_LINK
{
    public class Logic
    {
        public void PeopleCrossOut(int peopleCount, int personNumber)
        {
            int round = 1;

            int summOfPeople = peopleCount; // Needed to be split variable

            do
            {
                for (int i = 1; i <= peopleCount; i++)
                {
                    if (i % personNumber == 0)
                    {
                        --summOfPeople;

                        Console.WriteLine($"Раунд {round}. Вычеркнут человек. Людей осталось: {summOfPeople}");

                        round++;

                        Console.ReadKey(); // In the task writed "Poetapno" to show a result
                    }

                    if (personNumber > summOfPeople)
                    {
                        Console.WriteLine("Невозможно вычеркнуть человека");

                        return;
                    }
                }
            }

            while (summOfPeople != 1 || personNumber > summOfPeople);
        }
    }
}
