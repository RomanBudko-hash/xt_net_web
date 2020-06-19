namespace _2._2._1.GAME
{
    public class Mobs : EnitiesOnTheField
    {
        private readonly int _damage = 25;

        public Mobs(int PointOfBeingX, int PointOfBeingY)
        : base(PointOfBeingX, PointOfBeingY) { }

        public int DamageOfPlayer(Player player) => player.Health - _damage; // урон может получить только игрок
    }
}
