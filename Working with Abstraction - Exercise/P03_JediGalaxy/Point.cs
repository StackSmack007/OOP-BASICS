namespace P03_JediGalaxy
{
    public class Point
    {
        public Point(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
        public int Row { get; set; }
        public int Col { get; set; }

        public void NormalizeForEvilPath(int rowsSize, int colsSize)
        {
            int maxDiff = 0;
            if (this.Row > rowsSize)
            {
                maxDiff = this.Row - rowsSize + 1;
            }
            if (this.Col>colsSize&&this.Col-colsSize+1>rowsSize)
            {
                maxDiff = this.Col - colsSize + 1;
            }
            Row -= maxDiff;
            Col -= maxDiff;
        }

        public void NormalizeForIvoPath(int rowsSize, int colsSize)
        {
            int maxDiff = 0;
            if (this.Row>rowsSize)
            {
                maxDiff = this.Row - rowsSize + 1;
            }
            if (this.Col>colsSize&&this.Col-colsSize+1>maxDiff)
            {
                maxDiff = this.Col - colsSize + 1;
            }
            this.Row -= maxDiff;
            this.Col += maxDiff;
        }
    }
}
