namespace _2._2._1.GAME
{
    public class Player : EnitiesOnTheField
    {
        public Player(int PointOfBeingX, int PointOfBeingY)
        : base(PointOfBeingX, PointOfBeingY) { }

        public int GetHealth() => this.Health += 25;
    }
}
