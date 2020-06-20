namespace _2._2._1.GAME
{
    public abstract class Coordinates
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

        protected Coordinates(int PointOfBeingX, int PointOfBeingY)
        {
            this.PointOfBeingX = PointOfBeingX;
            this.PointOfBeingY = PointOfBeingY;
        }
    }
}
