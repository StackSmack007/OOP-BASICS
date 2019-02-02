namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0';

        public Wall(int cols,int rows) : base(rows,cols)//the size of the box change if need be
        {
            InitializeBorders();
        }

        private void InitializeBorders()
        {
            SetHorizontalBorder(0);
            SetHorizontalBorder(this.VerY);
            SetVerticalBorder(0);
            SetVerticalBorder(this.HorX - 1);
        }

        private void SetHorizontalBorder(int rowY)
        {
            for (int i = 0; i < this.HorX; i++)
            {
                Draw(i,rowY,wallSymbol);
            }
        }

        private void SetVerticalBorder(int colX)
        {
            for (int i = 0; i < this.VerY; i++)
            {
                Draw(colX, i, wallSymbol);
            }
        }
    }
}
