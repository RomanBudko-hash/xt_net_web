namespace _2._2._1.GAME
{
    public class Player : Coordinates
    {
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

        public Player(int PointOfBeingX, int PointOfBeingY)
        : base(PointOfBeingX, PointOfBeingY) { }

        public int GetHealth() => this.Health += 25;
    }
}
