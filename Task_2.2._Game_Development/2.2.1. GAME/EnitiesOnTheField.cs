namespace _2._2._1.GAME
{
    public abstract class EnitiesOnTheField
    {
        private int _pointOfBeingX;

        public int PointOfBeingX
        {
            get => _pointOfBeingX;

            set
            {
                if (value > Map.Width) // Не выходим за границы поля
                {
                    _pointOfBeingX = Map.Width;
                }
                if (value < 0)
                {
                    _pointOfBeingX = 0;
                }
            }
        }

        private int _pointOfBeingY;

        public int PointOfBeingY
        {
            get => _pointOfBeingY;

            set
            {
                if (value > Map.Height)
                {
                    _pointOfBeingY = Map.Height;
                }
                if (value < 0)
                {
                    _pointOfBeingY = 0;
                }
            }
        }

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
            }
        }

        protected EnitiesOnTheField(int PointOfBeingX, int PointOfBeingY)
        {
            this.PointOfBeingX = PointOfBeingX;
            this.PointOfBeingY = PointOfBeingY;
        }
    }
}
