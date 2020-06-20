namespace _2._2._1.GAME
{
    public class Mobs : Coordinates
    {
        private readonly int _damage = 25;

        private int _health = 100;

        public int Health
        {
            get => _health;

            set
            {
                if (value <= 100)
                {
                    _health = value;
                }
                else
                {
                    _health = 100;
                }
            }
        }

        public Mobs(int PointOfBeingX, int PointOfBeingY)
        : base(PointOfBeingX, PointOfBeingY) { }

        public int DamageOfPlayer(Player player) => player.Health - _damage; // урон может получить только игрок
    }
}
