using System;

namespace _3._1._1.WEAKEST_LINK
{
    public class Logic
    {
        private int peopleCount;

        public int PeopleCount
        {

            get => peopleCount;

            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Please, retry enter");
                }
                else
                {
                    peopleCount = value;
                }
            }
        }

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
