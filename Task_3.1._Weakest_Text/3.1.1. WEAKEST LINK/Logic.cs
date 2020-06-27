using System;

namespace _3._1._1.WEAKEST_LINK
{
    public class Logic
    {
        public void PeopleCrossOut(int N)
        {
            int round = 1;

            int summOfPeople = N; // needed to be split variable

            do
            {
                for (int i = 1; i <= N; i++)
                {
                    if (i % 2 == 0)
                    {
                        --summOfPeople;
                    }
                }

                Console.WriteLine($"Раунд {round}. Вычеркнут человек(-и). Людей осталось: {summOfPeople}");
                N = summOfPeople;
                round++;
            }
            while (summOfPeople != 1);
        }
    }
}
