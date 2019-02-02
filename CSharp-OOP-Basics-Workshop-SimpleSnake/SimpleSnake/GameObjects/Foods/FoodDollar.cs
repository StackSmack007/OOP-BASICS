namespace SimpleSnake.GameObjects.Foods
{
    public class FoodDollar : Food
    {
        private const char symbol='$';
        private const int points=2;

        public FoodDollar(Wall wall) : base(wall, points, symbol) { }
    }
}