using System;

namespace _3._1._1.WEAKEST_LINK
{
    public class Logic
    {
        public void PeopleCrossOut(int n, int number)
        {
            int round = 1;

            int summOfPeople = n; // Needed to be split variable

            do
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % number == 0)
                    {
                        --summOfPeople;
                    }
                }

                if (summOfPeople == n)
                {
                    Console.WriteLine("Невозможно вычеркнуть человека");
                    summOfPeople = 1;
                }
                else
                {
                    Console.WriteLine($"Раунд {round}. Вычеркнут человек(-и). Людей осталось: {summOfPeople}");
                    n = summOfPeople;
                    round++;
                    Console.ReadKey(); // In the task writed "Poetapno" to show a result
                }
            }
            while (summOfPeople != 1);
        }
    }
}
