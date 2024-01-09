namespace Matrix_Calculate
{
    public class matran
    {
        private int _dong;
        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }
        private int _cot;
        public int Cot
        {
            get { return _cot; }
            set { _cot = value; }
        }

        public int[,] Mt { get => mt; set => mt = value; }

        private int[,] mt;
        public matran(int d, int c)
        {
            Dong = d;
            Cot = c;
            Mt = new int[Dong, Cot];
        }

        public static matran Add(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = a.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = a.mt[i, j] + b.mt[i, j];
                }
            }
            return c;
        }
        public static matran Subtract(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = a.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = a.mt[i, j] - b.mt[i, j];
                }
            }
            return c;
        }
        public static matran Multiply(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = b.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = 0;
                    for (int k = 0; k < b.Dong; k++)
                    {
                        c.mt[i, j] += a.mt[i, k] * b.mt[k, j];
                    }
                }
            return c;
        }

        public override string ToString()
        {
            return string.Format("Row {0}: {1}, {2}\nRow {3}: {4}, {5}", 1, Mt[0, 0], Mt[0, 1], 2, Mt[1, 0], Mt[1,1]);
        }
    }
}