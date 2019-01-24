namespace P03_JediGalaxy
{
    public class Galaxy
    {
        public Galaxy(int rows, int cols)
        {
            this.Matrix = new int[rows, cols];
            FillMatrix();
        }
        public int[,] Matrix { get; set; }

        private void FillMatrix()
        {
            int value = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = value++;
                }
            }
        }

        public void EvilPath(Point basePoint)
        {
            while (basePoint.Row >= 0 && basePoint.Col >= 0)
            {
                if (IsInsideMatrix(basePoint))
                {
                    this.Matrix[basePoint.Row, basePoint.Col] = 0;
                }
                basePoint.Row--;
                basePoint.Col--;
            }
        }

        public long IvoPath(Point basePoint)
        {
            long result = 0;
            while (basePoint.Row >= 0 && basePoint.Col < Matrix.GetLength(1))
            {
                if (IsInsideMatrix(basePoint))
                {
                    result += this.Matrix[basePoint.Row, basePoint.Col];
                }
                basePoint.Row--;
                basePoint.Col++;
            }

            return result;
        }

        private bool IsInsideMatrix(Point point)
        {
            if (point.Row < this.Matrix.GetLength(0) && point.Col >= 0 && point.Row >= 0 && point.Col < this.Matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}